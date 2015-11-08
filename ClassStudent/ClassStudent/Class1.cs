using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMaterie;

namespace ClassStudent
{
    public class Student
    {
        private string Nume;
        private string Prenume;
        private int CNP;
        private int NrMatricol;

        public Student(int NrMatricol, string Nume, string Prenume, int CNP)
        {
            this.Nume = Nume;
            this.Prenume = Prenume;
            this.CNP = CNP;
            this.NrMatricol = NrMatricol;
        }
    }

    public class StudentFacultate : Student,DetaliiFacultate
    {
        List<Materie> listaMaterii = new List<Materie>();
        double medie = 0;
        private bool CerereCazareCamin;

        public StudentFacultate(int NrMatricol, string Nume, string Prenume, int CNP, List<Materie> listaMaterii, bool CerereCazareCamin)
            : base(NrMatricol, Nume, Prenume, CNP)
        {
            this.listaMaterii = listaMaterii;
            this.CerereCazareCamin = CerereCazareCamin;
        }

        public List<Materie> getList
        {
            get
            {
                return listaMaterii;
            }
        }
        public double _medie
        {
            get
            {
                return medie;
            }
            set
            {
                medie = value;
            }
        }
        public bool _cerereCazareCamin
        {
            get
            {
                return CerereCazareCamin;
            }
            set
            {
                CerereCazareCamin=value;
            }
        }
    }

    public class StudentCamin : Student, DetaliiCamin
    {
        double medie = 0;

        public StudentCamin(int NrMatricol, string Nume, string Prenume, int CNP, List<Materie> listaMaterii)
            : base(NrMatricol, Nume, Prenume, CNP)
        {
          
        }


        public double _medie
        {
            get
            {
                return medie;
            }

        }
    }

    interface DetaliiFacultate
    {
        bool _cerereCazareCamin
        {
            set;
            get;
        }

        double _medie
        {
            get;
            set;
        }
   
        List<Materie> getList
        {
            get;
        }
    }

    interface DetaliiCamin
    {
        double _medie
        {
            get;     
        }

    }
}
