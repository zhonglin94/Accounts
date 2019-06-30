using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oven
{
    class Program
    {
        static void Main(string[] args)
        {
            Oven oven = new Oven(100);
            oven.OverHeatEvent += new OvenEvent(() => { Console.WriteLine("Alarm!"); });
            oven.OverHeatEvent += new OvenEvent(() => { oven.TurnOff(); });

            oven.Run();
        }
    }
}
