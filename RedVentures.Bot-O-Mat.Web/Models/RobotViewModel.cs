namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class RobotViewModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public ErrandViewModel[] ErrandViewModel  { get; set; }
    }
}