using System;

namespace House_construction
{
    public class TeamLeader : IWorker
    {
        public void Build(House house)
        {
            if (house.house[0, 7] == "/" && house.house[0, 8] == "\\")
            {
                Console.WriteLine("Этап строительства дома: ");
                Console.WriteLine("Крыша построена");
                Console.WriteLine("Строительсво дома завершено");
            }
            else if (house.house[12, 12] == "-")
            {
                Console.WriteLine("Этап строительства дома: ");
                Console.WriteLine("Окно построено");
            }
            else if (house.house[8, 5] == "-")
            {
                Console.WriteLine("Этап строительства дома: ");
                Console.WriteLine("Дверь построена");
            }
            else if (house.house[8, 15] == "|")
            {
                Console.WriteLine("Этап строительства дома: ");
                Console.WriteLine("Стены построены");
            }
            else if (house.house[13, 15] == "-")
            {
                Console.WriteLine("Этап строительства дома: ");
                Console.WriteLine("Фундамент построен");
            }
            else
            {
                Console.WriteLine("Этап строительства дома: ");
                Console.WriteLine("Строительсвтво не начато");
            }
        }
    }
}