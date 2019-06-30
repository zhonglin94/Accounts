using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Oven
{
    public delegate void OvenEvent();
    public class Oven
    {
        public event OvenEvent OverHeatEvent;

        private int Temp;
        public bool IsOn = false;

        public int ThresholdTemp { get; set; }
        public Oven() : this(37, 100) { }
        public Oven(int thresholdTemp) : this(37, thresholdTemp) { }
        public Oven(int temp, int thresholdTemp)
        {
            Temp = temp;
            ThresholdTemp = thresholdTemp;
        }

        public void Run()
        {
            TurnOn();
            while (IsOn)
            {
                Heating();
                if (IsOverheating())
                {
                    OverHeatEvent();
                }
                Thread.Sleep(1000);
            }
        }
        private bool IsOverheating()
        {
            return Temp >= ThresholdTemp;
        }


        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Oven is turned off.");
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Oven is turned on");
        }

        private void Heating()
        {
            Temp += 1;
            Console.WriteLine("The temperature is: {0}°C", Temp);
        }

    }
}
