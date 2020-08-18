namespace House_construction
{
    public class House
    {
        public const int ARRAY_WIDTH = 16;
        public const int ARRAY_LENGHT = 14;
        public string[,] house = new string[ARRAY_LENGHT, ARRAY_WIDTH];

        public House()
        {
            for (int i = 0; i < ARRAY_LENGHT; i++)
            {
                for (int j = 0; j < ARRAY_WIDTH; j++)
                {
                    house[i, j] = " ";
                }
            }
        }

        public int GetArrayWitdh()
        {
            return ARRAY_WIDTH;
        }

        public int GetArrayLenght()
        {
            return ARRAY_LENGHT;
        }
    }
}