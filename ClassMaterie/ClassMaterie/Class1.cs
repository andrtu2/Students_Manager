using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace ClassMaterie
{
    public class Materie
    {
        private string Nume;
        private float Medie;

        public Materie(string Nume, float Medie)
        {
            this.Nume = Nume;
        }

        public string setMedia
        {
            set { Medie = float.Parse(value); }
        }
    }
}
