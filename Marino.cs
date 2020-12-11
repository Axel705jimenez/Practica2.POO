using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaclase
{
    class Marino : Animal
    {
        protected string nombreDelAnimal;

        public string NombreDelAnimal
        {
            get { return nombreDelAnimal; }
            set { nombreDelAnimal = value; }
        }
        public Marino() : base()
        {
            nombreDelAnimal = "";
        }
        public override string ToString()
        {
            return nombreDelAnimal + " " + base.ToString();
        }
    }
}
