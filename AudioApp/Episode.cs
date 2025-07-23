namespace AudioApp;
using UserData;
public class Episode
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public string AudioPath { get; set;}
    public bool AgeLimit  { get; set;}
    public DateTime DateUploaded { get; set; }
    public ApplicationUser CreatedBy { get; set;}
    public string AudioCoverImagePath { get; set;}
    
    public MainStory MainStory { get; set;}
    
    public int MainStoryId { get; set;}
    

}
