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
 
        public Materie(string Nume)
        {
            this.Nume = Nume;
        }

        public string getNume
        {
            get { return Nume; }
        }


    }

    public class MaterieStudent: Materie,NoteMaterie
    {

        private double Medie;

        public MaterieStudent(string Nume):base(Nume)
        {
           
        }

        public double _media
        {
            set { Medie = value; }
            get { return Medie; }
        }
    }

    interface NoteMaterie
    {
        double _media
        {
            set;
            get;
        }
    }

}
