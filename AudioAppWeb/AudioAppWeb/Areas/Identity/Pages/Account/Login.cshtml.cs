// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AudioApp.UserData;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AudioAppWeb.Areas.Identity.Pages.Account
{
    /// <summary>
    /// This LoginModel class is connected to the Login page of our web app.
    /// It helps us manage everything that happens when a user tries to log in.
    /// The code checks the user's input (email and password), talks to the Identity system,
    /// and decides if the login should succeed or fail.
    /// Think of this as the "controller" behind the login form.
    /// </summary>
    [AllowAnonymous] // Anyone can access this page, even if not logged in
    public class LoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<LoginModel> _logger;

        /// <summary>
        /// The constructor sets up the tools we need:
        /// - SignInManager: helps us sign in users with username + password
        /// - UserManager: helps us find users in the database and manage them
        /// - Logger: lets us write information to the log (for debugging or tracking)
        /// </summary>
        public LoginModel(
            SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager,
            ILogger<LoginModel> logger)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }

        /// <summary>
        /// InputModel holds the values the user types in the login form.
        /// When the form is submitted, ASP.NET automatically fills these properties.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        /// A list of external logins (like Google, Facebook, etc.) that can be shown on the login page.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        /// Where to go after login is successful. If not set, we go back to home page.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Error messages stored temporarily, e.g., if login failed.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The input model for login form.
        /// This defines what fields exist on the form and applies rules like "required" or "must be email".
        /// </summary>
        public class InputModel
        {
            /// <summary>
            /// User must type their email. This is marked as [Required].
            /// The [EmailAddress] ensures it looks like a proper email (example@domain.com).
            /// </summary>
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            /// <summary>
            /// User must type their password. The [DataType] tells the form to hide characters (*****).
            /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            /// <summary>
            /// A checkbox: if true, the login cookie will stay even after browser is closed.
            /// This means "Remember me".
            /// </summary>
            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        /// <summary>
        /// Called when the login page is first opened (GET request).
        /// We clear any old cookies (to avoid conflicts),
        /// load external login options,
        /// and prepare the page to display.
        /// </summary>
        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                // Show error messages if any were set
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            // If no return URL was given, go to home page after login
            returnUrl ??= Url.Content("~/");

            // Log out of any external login (like Google) to make sure the login page is clean
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            // Load list of external login providers
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        /// <summary>
        /// Called when the user submits the login form (POST request).
        /// This method:
        /// 1. Checks if the form input is valid.
        /// 2. Finds the user in the database using their email.
        /// 3. If user exists, tries to log them in using their stored username and the password they typed.
        /// 4. Returns success, requires 2FA, locked out, or failed login depending on the result.
        /// </summary>
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            // If input validation failed (like missing email or password), reload the page
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Step 1: Find user by email in the database
            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                // If no user with this email, show error
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }

            // Step 2: Try to sign in using the username found and the password typed
            var result = await _signInManager.PasswordSignInAsync(
                user.UserName,        // The actual username in DB
                Input.Password,       // The password typed in form
                Input.RememberMe,     // Whether to stay logged in
                lockoutOnFailure: false); // Don’t lock the account after multiple failures

            // Step 3: Handle results
            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in successfully.");
                return LocalRedirect(returnUrl); // Go to requested page or home
            }
            if (result.RequiresTwoFactor)
            {
                // If 2FA is enabled, redirect to 2FA login page
                return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning("User account is locked out due to too many failed attempts.");
                return RedirectToPage("./Lockout");
            }

            // If we reach here, login failed (wrong email or password)
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }
    }
}
