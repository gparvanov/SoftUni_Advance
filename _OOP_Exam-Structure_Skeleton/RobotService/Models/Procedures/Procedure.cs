using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotService.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {
        protected IList<IRobot> Robots { get; }

        protected Procedure()
        {
            this.Robots = new List<IRobot>();
        }
        public virtual void DoService(IRobot robot, int procedureTime)
        {
            int robotTime = robot.ProcedureTime;

            if(robotTime < procedureTime)
            {
                throw new ArgumentException(ExceptionMessages.InsufficientProcedureTime);
            }
            else
            {
                robot.ProcedureTime -= procedureTime;
            }
        }

        public string History()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");
            foreach (var robot in Robots)
            {
                sb.AppendLine($" Robot type: {robot.GetType()} - {robot.Name} - Happiness: {robot.Happiness} - Energy: {robot.Energy}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
