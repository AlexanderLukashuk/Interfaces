namespace House_construction
{
    public class Door : IPart
    {
        public string[,] HouseDoor { get; set; }
        public void Part()
        {
            HouseDoor = new string[,]
            {{"_", "_", "_", "_", "_"},
             {"|", " ", " ", " ", "|"},
             {"|", ".", " ", " ", "|"},
             {"|", " ", " ", " ", "|"},
             {"|", " ", " ", " ", "|"}
            };
        }
    }
}