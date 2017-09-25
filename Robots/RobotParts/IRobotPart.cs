using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots.RobotParts
{
    public abstract class IRobotPart
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string ActionMessage { get; private set; }        
        
        public IRobotPart(string name, string desc, string actionMessages )
        {
            this.Name = name;
            this.Description = desc;
            this.ActionMessage = actionMessages;
        }

        public override string ToString ( )
        {
            return
                $"Name: {Name}\n" +
                $"Desc: {Description}\n";
        }
    }
}
