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
            if (SNR_IR >= SNR_RF && SNR_IR >= SNR_Bluetooth)
            {
                IR = true;
                RF = false;
                Bluetooth = false;
                Console.WriteLine("Quadcopter IRRFBluetooth is now using IR communication");
            }
            else if(SNR_RF>=SNR_IR && SNR_RF>=SNR_Bluetooth)
            {
                RF = true;
                IR = false;
                Bluetooth = false;
                Console.WriteLine("Quadcopter IRRFBluetooth is now using RF communication");
            }
            else
            {
                RF = false;
                IR = false;
                Bluetooth = true;
                Console.WriteLine("Quadcopter IRRFBluetooth is now using bluetooth communication");
            }

        }
    }
}
