using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotterne_kommer
{
    internal class Robot
    {
        private string type;
        private string color;
        private string chip;
        private bool wifi;
        private byte batterycap;
        private int size;
        private bool soapdispenser;
        private int wheels;

        public string Type
        {
            get { return type; }
        }

        public string Color
        {
            get { return color; }
        }

        public string Chip
        {
            get { return chip; }
        }

        public bool Wifi
        {
            get { return wifi; }
        }

        public byte BatteryCap
        {
            get { return batterycap; }
            set { batterycap = value; }
        }

        public int Size
        {
            get { return size; }
        }

        public bool Soapdispenser
        {
            get { return soapdispenser; }
        }

        public int Wheels
        {
            get { return wheels; }
        }

        private Robot(string type, int size, string chip)
        {
            
            this.type = type;
            this.size = size;
            this.chip = chip;
            
        }

        // This is experimental, no judging
        private Robot(bool wifi, string type, int size, string chip): this(type, size, chip)
        {

            this.wifi = wifi;

        }

        public Robot(bool wifi, string type, int size, string chip, int wheels):this(wifi, type, size, chip)
        {

            this.wheels = wheels;
            
        }

        public Robot(bool wifi, string type, int size, string chip, int wheels, byte batterycap):this(wifi, type, size, chip, wheels)
        {
            this.color = "White";
            this.batterycap = batterycap;
        }

        public Robot(bool wifi, string type, int size, string chip, int wheels, bool soapdispense, string color):this(wifi, type, size, chip, wheels)
        {
            this.soapdispenser = soapdispense;
            this.color = color;
        }




    }
}
