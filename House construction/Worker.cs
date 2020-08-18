using System;

namespace House_construction
{
    public class Worker : IWorker
    {
        public void Build(House house)
        {
            Basement basement = new Basement();
            basement.Part();
            Walls wall = new Walls();
            wall.Part();
            Door door = new Door();
            door.Part();
            Window window = new Window();
            window.Part();
            Roof roof = new Roof();
            roof.Part();
            for (int i = house.GetArrayLenght() - 1; i >= 0; i--)
            {
                for (int j = 0; j < house.GetArrayWitdh(); j++)
                {
                    if (i == house.GetArrayLenght() - 1)
                    {
                        house.house[i, j] = basement.HouseBasement;
                    }
                    else if ((j == 0 || j == house.GetArrayWitdh() - 1) && i >= 7)
                    {
                        house.house[i, j] = wall.HouseWall;
                    }
                    else if (j == 1 && i == house.GetArrayLenght() - 2)
                    {
                        int tmp = 4;
                        int tmpi = i;
                        for (int n = i; n > (i - 5); n--)
                        {
                            for (int m = j; m < (j + 5); m++)
                            {
                                house.house[n, m] = door.HouseDoor[tmpi + tmp - n, m - j];
                            }
                            tmp--;
                            tmpi--;
                        }
                    }
                    else if (j == 9 && i == house.GetArrayLenght() - 6)
                    {
                        for (int n = i; n < i + 4; n++)
                        {
                            for (int m = j; m < j + 4; m++)
                            {
                                house.house[n, m] = window.HouseWindow[n - i, m - j];
                            }
                        }
                    }
                    else if (i == 0 && j == 0)
                    {
                        for (int n = i; n < i + 8; n++)
                        {
                            for (int m = j; m < house.GetArrayWitdh(); m++)
                            {
                                house.house[n, m] = roof.HouseRoof[n - i, m - j];
                            }
                        }
                    }
                }
            }
        }
    }
}