using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_14
{
    [AttributeUsage(AttributeTargets.All)]
    public class UserAttribute: Attribute
    {
        private string name;
        public readonly string description;

        public UserAttribute(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
