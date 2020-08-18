namespace House_construction
{
    public class Window : IPart
    {
        public string[,] HouseWindow { get; set; }
        public void Part()
        {
            HouseWindow = new string[,]
            {
                {"-", "-", "-", "-"},
                {"|", " ", " ", "|"},
                {"|", " ", " ", "|"},
                {"-", "-", "-", "-"},
            };
        }
    }
}