using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Garages
{
    public class Garage : IGarage
    {
        private readonly Dictionary<string,IRobot> robots;

        private int capacity;

        public int Capacity
        {
            get => capacity;
            private set 
            { 
                capacity = value; 
            }
        }        

        public Garage()
        {
            this.Capacity = 10;
            this.robots = new Dictionary<string, IRobot>();
        }
        public IReadOnlyDictionary<string, IRobot> Robots
        { get => robots; }

        public void Manufacture(IRobot robot)
        {
            int currentCapacity = robots.Count;

            if(currentCapacity == this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.NotEnoughCapacity);
            }
            else if (robots.ContainsKey(robot.Name))
            {
                string message = string.Format(ExceptionMessages.ExistingRobot,robot.Name);
                throw new ArgumentException(message);
            }
            else
            {                
                robots.Add(robot.Name, robot);
            }
        }

        public void Sell(string robotName, string ownerName)
        {
            if (!robots.ContainsKey(robotName))
            {
                string message = string.Format(ExceptionMessages.InexistingRobot, robotName);
                throw new ArgumentException(message);
            }
            else
            {
                var selledRobot = robots[robotName];
                selledRobot.Owner = ownerName;
                selledRobot.IsBought = true;
                robots.Remove(robotName);
            }
        }
    }
}
