namespace AudioApp;

public class MainStory
{
   public int ID { get; set; }
   public List<Episode>  Episodes { get; set; } = new List<Episode>();
   public double Price{ get; set; }
   public String Name{ get; set; }
   public String CoverPath { get; set; }
}