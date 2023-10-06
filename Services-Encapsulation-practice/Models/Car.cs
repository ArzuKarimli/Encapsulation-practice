using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Encapsulation_practice.Models
{
    internal class Car
    {
        public int speed;
        public string color;
        private string vin;

        public string Vin
        {

            get
            {
                if (speed > 450)
                {
                    return vin;
                }return null;
            }
           
            set
            {
               vin = value;
            }


        }


    }
}
