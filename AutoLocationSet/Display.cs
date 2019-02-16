using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLocationSet
{
    class Display
    {
        private string name;
        private int height;
        private int width;
        private bool primary;

        public Display()
        {
            this.name = "Display 1";
            this.height = 2560;
            this.width = 1440;
            this.primary = true;
        }
        public Display(string inputName, int inputWidth, int inputHeight, bool inputPrimary)
        {
            this.name = inputName;
            this.height = inputHeight;
            this.width = inputWidth;
            this.primary = inputPrimary;
        }

        internal bool IsPrimary()
        {
            return this.primary;
        }
        internal string GetName()
        {
            return this.name;
        }
        internal string GetResolution()
        {
            return this.width + " x " + this.height;
        }
        internal int GetWidth()
        {
            return this.width;
        }
        internal int GetHeight()
        {
            return this.height;
        }
    }
}
