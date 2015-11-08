using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProfesor
{
    public class Profesor
    {
        private string Nume;
        private string Prenume;
        private int CNP;
        private int Identificator;
        private string NumeMateriePredata;

        public Profesor(int Identificator, string Nume, string Prenume, int CNP, string NumeMateriePredata)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.CNP = CNP;
            this.Identificator = Identificator;
            this.NumeMateriePredata = NumeMateriePredata;
        }
    }
}
