using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9Queadcopters
{
    class QuadcopterIRRFBluetooth : QuadcopterIRRF
    {
        new public void select_comm_method()
        {

            Dictionary<string, float> types = new Dictionary<string, float>()
            {

            {"IR", SNR_IR },
            {"RF", SNR_RF},
            {"Bluetooth", SNR_Bluetooth },


            };

            var max = types.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            




            if (max == "IR") { IR = true; RF = false; Bluetooth = false; }
            else if(max == "Bluetooth") { Bluetooth = true; IR = false; RF = false; }
            else { RF = true; IR = false; Bluetooth = false; }

            Console.WriteLine("Quadcopter IRRF is now using {0} communication", max);
            Console.WriteLine("IR:{0} RF:{1}  BT:{2}", IR, RF,Bluetooth);











            

        }
    }
}
