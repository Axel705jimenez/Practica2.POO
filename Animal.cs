using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaclase
{
    class Animal
    {
        protected string tipoDeAnimal;

        public string TipoDdeAnimal
        {
            get { return tipoDeAnimal; }
            set { tipoDeAnimal = value; }
        }
        public Animal()
        {
            tipoDeAnimal = "";
        }
        public override string ToString()
        {
            return tipoDeAnimal + "";
        }

    }
}
