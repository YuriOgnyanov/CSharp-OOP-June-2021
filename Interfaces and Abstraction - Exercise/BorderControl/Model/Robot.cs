using BorderControl.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Model
{
    public class Robot : IRobotable
    {
        public string Model { get; private set; }

        public string Id { get; private set; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
