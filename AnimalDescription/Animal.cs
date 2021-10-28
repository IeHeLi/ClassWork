using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDescription
{
    class Animal
    {
        private string EyeColour;
        private string SkinColour;
        private string Weight;
        private string Height;
        private string Age;

        public string eyeColour
        {
            get { return this.EyeColour; }
            set { this.EyeColour = value; }
        }

        public string skinColour
        {
            get { return this.SkinColour; }
            set { this.SkinColour = value; }
        }

        public string weight
        {
            get { return this.Weight; }
            set { this.Weight = value; }
        }

        public string height
        {
            get { return this.Height; }
            set { this.Height = value; }
        }

        public string age
        {
            get { return this.Age; }
            set { this.Age = value; }
        }


    }
}
