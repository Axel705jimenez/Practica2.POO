using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaclase
{
    class Delfin : Marino
    {
        protected string piel;
        protected string habitat;

        public string Piel
        {
            get { return piel; }
            set { piel = value; }
        }

        public string Habitat
        {
            get { return habitat; }
            set { habitat = value; }
        }

        public Delfin(): base()
        {
            piel = "";
            habitat = "";
        }
        public override string ToString()
        {
            return piel + "" + habitat + "" + base.ToString();
        }
    }
}
