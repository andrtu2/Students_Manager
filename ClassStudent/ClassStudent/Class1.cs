using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    public class Student
    {
        private string Nume;
        private string Prenume;
        private int CNP;
        private int NrMatricol;

        public Student(string Nume, string Prenume, int CNP,int NrMatricol)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.CNP = CNP;
            this.NrMatricol = NrMatricol;
        }
    }
}
