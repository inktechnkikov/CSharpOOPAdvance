using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
   public class Rectangle
    {
        private double height;
        private double width;

        public virtual double Width
        {
            get { return this.width; }
            set { width = value; }
        }

        public virtual double Height
        {
            get { return this.height; }
            set { height = value; }
        }
        
      
    }
}
