namespace House_construction
{
    public class Walls : IPart
    {
        public string HouseWall { get; set; }
        public void Part()
        {
            HouseWall = "|";
        }
    }
}