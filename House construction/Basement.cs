using System;

namespace House_construction
{
    public class Basement : IPart
    {
        public string HouseBasement { get; set; }
        public void Part()
        {
            HouseBasement = "-";
        }
    }
}