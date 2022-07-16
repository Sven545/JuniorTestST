using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorTest2
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public override bool Equals(object obj)
        {
            if ((object)this == obj) 
                return true;

            if (obj == null)
                return false;

            var otherObject = obj as Car;
            if (otherObject == null)
                return false;

            if((Model==otherObject.Model)&&(Color==otherObject.Color))
            {
                return true;

            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode()^(Model.GetHashCode()*Color.GetHashCode());
        }

    }
}
