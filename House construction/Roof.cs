namespace House_construction
{
    public class Roof : IPart
    {
        public string[,] HouseRoof { get; set; }

        public void Part()
        {
            HouseRoof = new string[,]
            {
             {" ", " ", " ", " ", " ", " ", " ", "/", "\\", " ", " ", " ", " ", " ", " ", " "},
             {" ", " ", " ", " ", " ", " ", "/", " ", " ", "\\", " ", " ", " ", " ", " ", " "},
             {" ", " ", " ", " ", " ", "/", " ", " ", " ", " ", "\\", " ", " ", " ", " ", " "},
             {" ", " ", " ", " ", "/", " ", " ", " ", " ", " ", " ", "\\", " ", " ", " ", " "},
             {" ", " ", " ", "/", " ", " ", " ", " ", " ", " ", " ", " ", "\\", " ", " ", " "},
             {" ", " ", "/", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "\\", " ", " "},
             {" ", "/", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "\\", " "},
             {"/", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "_", "\\"}
            };
        }
    }
}