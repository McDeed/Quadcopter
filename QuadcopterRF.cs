using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9Queadcopters
{
    class QuadcopterRF : Random, IQuadcopter
    {
        public bool Bluetooth { get; set; }

        public bool IR { get; set; }

        public bool RF { get; set; }

        public float SNR_Bluetooth { get; set; }

        public float SNR_RF { get; set; }

        public float SNR_IR { get; set; }
        Random rand = new Random(DateTime.Now.Millisecond);

        public void rand_SNR()
        {
            SNR_IR = (float)(Next(20));
            SNR_Bluetooth = (float)(Next(20));
            SNR_RF = (float)(Next(20));
        }

        public int[] return_current_coordinates()
        {
            {
                int[] coords = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    coords[i] = rand.Next(50);
                }


                Console.WriteLine("The coordinates(x,y,z) are {0},{1},{2}", coords[0], coords[1], coords[2]);

                return coords;


            }
        }

        public void select_comm_method()
        {
            RF = true;
            Console.WriteLine("Quadcopter RF is now using RF communication");
        }

    }
}
