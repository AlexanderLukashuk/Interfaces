using System;

namespace House_construction
{
    class Program
    {
        static void Main(string[] args)
        {
            House myHouse = new House();
            Worker worker = new Worker();
            TeamLeader teamLeader = new TeamLeader();
            worker.Build(myHouse);
            teamLeader.Build(myHouse);
            for (int i = 0; i < myHouse.GetArrayLenght(); i++)
            {
                for (int j = 0; j < myHouse.GetArrayWitdh(); j++)
                {
                    Console.Write(myHouse.house[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
