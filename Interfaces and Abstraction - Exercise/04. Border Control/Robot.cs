using System;
using System.Collections.Generic;
using System.Text;

namespace Border_Control
{
    public class Robot : Creature
    {
        private string model;

        public string Model
        {
            get => model;
            set
            {
                model = value;
            }
        }
                

        public string Id { get; set; }

        public Robot(string name, string id)
        {
            this.Model = model;            
            this.Id = id;
        }
    }
}
