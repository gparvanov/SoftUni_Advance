using RobotService.Core.Contracts;
using RobotService.Models.Garages;
using RobotService.Models.Garages.Contracts;
using RobotService.Models.Procedures;
using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Enums;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private readonly IGarage garage;
        private readonly Dictionary<ProceduresTypes,IProcedure> procedures;
        private readonly Dictionary<string, List<IRobot>> activities;

        public Controller()
        {
            garage = new Garage();
            this.procedures = new Dictionary<ProceduresTypes, IProcedure>();
            this.activities = new Dictionary<string, List<IRobot>>();
            this.SeedProcedures();
        }        
        
        public string Charge(string robotName, int procedureTime)
        {
            if (garage.Robots.ContainsKey(robotName))
            {
                IProcedure procedure = this.procedures[ProceduresTypes.Charge];
                var currentRobot = garage.Robots[robotName];
                procedure.DoService(currentRobot, procedureTime);
                if (!activities.ContainsKey("Charge")) activities["Charge"] = new List<IRobot>();
                activities["Charge"].Add(currentRobot);                
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InexistingRobot, robotName);
            }
            return $"{robotName} had charge procedure";
        }

        public string Chip(string robotName, int procedureTime)
        {
            if (garage.Robots.ContainsKey(robotName))
            {
                IProcedure procedure = this.procedures[ProceduresTypes.Chip];
                var currentRobot = garage.Robots[robotName];
                procedure.DoService(currentRobot, procedureTime);
                if (!activities.ContainsKey("Chip")) activities["Chip"] = new List<IRobot>();
                activities["Chip"].Add(currentRobot);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InexistingRobot, robotName);
            }
            return $"{robotName} had chip procedure";
        }

        public string History(string procedureType)
        {
            StringBuilder sb = new StringBuilder();            
            foreach (var procedure in activities.Where(x => x.Key == procedureType))
            {
                sb.AppendLine($"{procedure.Key}");
                var innerList = procedure.Value;
                foreach (var robot in innerList)
                {
                    sb.AppendLine($" Robot type: {robot.GetType().Name} - {robot.Name} - Happiness: {robot.Happiness} - Energy: {robot.Energy}");
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime)
        {
            IRobot robot;
            if (robotType == "HouseholdRobot")
            {
                robot = new HouseholdRobot(name, energy, happiness, procedureTime);
                garage.Manufacture(robot);
            }
            else if (robotType == "WalkerRobot")
            {
                robot = new WalkerRobot(name, energy, happiness, procedureTime);
                garage.Manufacture(robot);
            }
            else if (robotType == "PetRobot")
            {
                robot = new PetRobot(name, energy, happiness, procedureTime);
                garage.Manufacture(robot);
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidRobotType,robotType));
            }
            string successfullMessage = $"Robot {name} registered successfully";
            return successfullMessage;
        }

        public string Polish(string robotName, int procedureTime)
        {
            if (garage.Robots.ContainsKey(robotName))
            {
                IProcedure procedure = this.procedures[ProceduresTypes.Polish];
                var currentRobot = garage.Robots[robotName];
                procedure.DoService(currentRobot, procedureTime);
                if (!activities.ContainsKey("Polish")) activities["Polish"] = new List<IRobot>();
                activities["Polish"].Add(currentRobot);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InexistingRobot, robotName);
            }
            return $"{robotName} had polish procedure";
        }

        public string Rest(string robotName, int procedureTime)
        {
            if (garage.Robots.ContainsKey(robotName))
            {
                IProcedure procedure = this.procedures[ProceduresTypes.Rest];
                var currentRobot = garage.Robots[robotName];
                procedure.DoService(currentRobot, procedureTime);
                if (!activities.ContainsKey("Rest")) activities["Rest"] = new List<IRobot>();
                activities["Rest"].Add(currentRobot);
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            return $"{robotName} had rest procedure";
        }

        public string Sell(string robotName, string ownerName)
        {
            bool isRobotChipped = false;
            if (garage.Robots.ContainsKey(robotName))
            {
                var currentRobot = garage.Robots[robotName];
                if (currentRobot.IsChipped) isRobotChipped = true;
                garage.Sell(robotName,ownerName);                
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }

            if (isRobotChipped) return $"{ownerName} bought robot with chip";
            else return $"{ownerName} bought robot without chip";
        }

        public string TechCheck(string robotName, int procedureTime)
        {
            if (garage.Robots.ContainsKey(robotName))
            {
                IProcedure procedure = this.procedures[ProceduresTypes.TechCheck];
                var currentRobot = garage.Robots[robotName];
                procedure.DoService(currentRobot, procedureTime);
                if (!activities.ContainsKey("TechCheck")) activities["TechCheck"] = new List<IRobot>();
                activities["TechCheck"].Add(currentRobot);
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            return $"{robotName} had tech check procedure";
        }

        public string Work(string robotName, int procedureTime)
        {
            if (garage.Robots.ContainsKey(robotName))
            {
                IProcedure procedure = this.procedures[ProceduresTypes.Work];
                var currentRobot = garage.Robots[robotName];
                procedure.DoService(currentRobot, procedureTime);
                if (!activities.ContainsKey("Work")) activities["Work"] = new List<IRobot>();
                activities["Work"].Add(currentRobot);
            }
            else
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InexistingRobot, robotName));
            }
            return $"{robotName} was working for {procedureTime} hours";
        }
        private void SeedProcedures()
        {
            this.procedures.Add(ProceduresTypes.Chip, new Chip());
            this.procedures.Add(ProceduresTypes.Charge, new Charge());
            this.procedures.Add(ProceduresTypes.Rest, new Rest());
            this.procedures.Add(ProceduresTypes.Polish, new Polish());
            this.procedures.Add(ProceduresTypes.Work, new Work());
            this.procedures.Add(ProceduresTypes.TechCheck, new TechCheck());
        }
    }
}
