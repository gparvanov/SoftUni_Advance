using System;
using System.Collections.Generic;
using System.Linq;

namespace Border_Control
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split();
            List<Creature> ids = new List<Creature>();

            while(inputData[0] != "End")
            {
                if(inputData.Length == 3)
                {
                    string humanName = inputData[0];
                    int age = int.Parse(inputData[1]);
                    string id = inputData[2];
                    Citizen citizen = new Citizen(humanName, age, id);
                    ids.Add(citizen);

                }
                else if (inputData.Length == 2)
                {
                    string robotModel = inputData[0];                    
                    string id = inputData[1];
                    Robot robot = new Robot(robotModel, id);
                    ids.Add(robot);
                }
                inputData = Console.ReadLine().Split();
            }

            string endString = Console.ReadLine();

            foreach (var record in ids)
            {
                if(record is Citizen citizen)
                {
                    if(citizen.Id.EndsWith(endString)) Console.WriteLine(citizen.Id);
                }
                else if (record is Robot robot)
                {
                    if (robot.Id.EndsWith(endString)) Console.WriteLine(robot.Id);
                }
            }
        }
    }
}