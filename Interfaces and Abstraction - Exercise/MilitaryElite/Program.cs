using System;
using System.Collections.Generic;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<ISoldier> soldiers = new List<ISoldier>();
            while(input != "End")
            {
                
                string[] inputData = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if(inputData[0] == "Private")
                {
                    try
                    {
                        int id = int.Parse(inputData[1]);
                        string privateFirstName = inputData[2];
                        string privateLastName = inputData[3];
                        decimal privateSalary = decimal.Parse(inputData[4]);
                        Private privateSoldier = new Private(id, privateFirstName, privateLastName, privateSalary);                        
                        soldiers.Add(privateSoldier);
                    }
                    catch (Exception e)
                    {

                    }
                }
                else if ( inputData[0] == "LieutenantGeneral")
                {
                    try
                    {
                        int id = int.Parse(inputData[1]);
                        string generalFirstName = inputData[2];
                        string generalLastName = inputData[3];
                        decimal generalSalary = decimal.Parse(inputData[4]);
                        List<Private> privates = new List<Private>();
                        for (int i = 5; i < inputData.Length; i++)
                        {
                            int privateId = int.Parse(inputData[i]);
                            foreach (var person in soldiers)
                            {
                                if (person is Private privatePerson && privatePerson.Id == privateId)
                                {
                                    Private privateSoldier = new Private(privatePerson.Id,
                                        privatePerson.FirstName,
                                        privatePerson.LastName,
                                        privatePerson.Salary);
                                    privates.Add(privateSoldier);
                                }
                            }
                        }
                        LieutenantGeneral general = new LieutenantGeneral(id, generalFirstName, generalLastName, generalSalary, privates);
                        soldiers.Add(general);
                    }
                    catch (Exception e)
                    {

                    }
                }
                else if (inputData[0] == "Spy")
                {
                    try
                    {
                        int id = int.Parse(inputData[1]);
                        string spyFirstName = inputData[2];
                        string spyLastName = inputData[3];
                        int spyCodeNumber = int.Parse(inputData[4]);
                        Spy spySoldier = new Spy(id, spyFirstName, spyLastName, spyCodeNumber);
                        soldiers.Add(spySoldier);
                    }
                    catch(Exception e)
                    {

                    }
                }
                else if (inputData[0] == "Engineer")
                {
                    try
                    {
                        int id = int.Parse(inputData[1]);
                        string engineerFirstName = inputData[2];
                        string engineerLastName = inputData[3];
                        decimal engineerSalary = decimal.Parse(inputData[4]);
                        string engineerCorps = inputData[5];
                        if (engineerCorps == "Marines" || engineerCorps == "Airforces")
                        {
                            Dictionary<string, int> repairs = new Dictionary<string, int>();
                            for (int i = 6; i < inputData.Length; i += 2)
                            {
                                string repairPart = inputData[i];
                                int repairHours = int.Parse(inputData[i + 1]);
                                repairs[repairPart] = repairHours;
                            }
                            Engineer engineer = new Engineer(id, engineerFirstName, engineerLastName, engineerSalary, engineerCorps, repairs);
                            soldiers.Add(engineer);
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                else if (inputData[0] == "Commando")
                {
                    try
                    {
                        int id = int.Parse(inputData[1]);
                        string commandoFirstName = inputData[2];
                        string commandoLastName = inputData[3];
                        decimal commandoSalary = decimal.Parse(inputData[4]);
                        string commandoCorps = inputData[5];
                        if (commandoCorps == "Marines" || commandoCorps == "Airforces")
                        {
                            Dictionary<string, string> missions = new Dictionary<string, string>();
                            for (int i = 6; i < inputData.Length; i += 2)
                            {
                                string missionCodeName = inputData[i];
                                string missionState = inputData[i + 1];
                               if(missionState== "Finished" || missionState == "inProgress") missions[missionCodeName] = missionState;
                            }
                            Commando commando = new Commando(id, commandoFirstName, commandoLastName, commandoSalary, commandoCorps, missions);
                            //commando.CompleteMission("Freedom");
                            soldiers.Add(commando);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }
    }
}