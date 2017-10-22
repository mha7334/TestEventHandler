using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c = new Car();
            c.OnChange += C_OnChange;
        }

        private static void C_OnChange()
        {
            Console.WriteLine("EVENT Fired if sped > 60!");
        }
    }


    class Car
    {
        public event Action OnChange;
        private double speed;

        public double Speed
        {
            get { return speed; }
            set
            {
                speed = value;
                if(speed >= 60)
                {
                    if(OnChange != null)
                    {
                        OnChange();
                    }
                }
            }
        }
    }
    



}
