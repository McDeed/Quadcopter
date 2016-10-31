using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9Queadcopters
{
    class QuadcopterIRRF : QuadcopterIR
    {

        new public void select_comm_method()
        {
            //creating a dictionary to link strings to corresponding SNR value
            Dictionary<string, float> types = new Dictionary<string, float>()
            {

            {"IR", SNR_IR },
            {"RF", SNR_RF},
            

            };
            //gives max the string thats linked to the highest SNR value
            var max = types.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            if(max == "IR") { IR = true;RF = false; }
            else { RF = true; IR = false; }

            Console.WriteLine("Quadcopter IRRF is now using {0} communication", max);
            //Console.WriteLine("IR:{0} RF:{1}",IR,RF);

        









            

        }

    }
}
