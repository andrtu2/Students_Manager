﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassProfesor;
using ClassMaterie;
using ClassStudent;

namespace ClassSecretariat
{
    public class Secretariat
    {
        List<StudentFacultate> ListaStudenti = new List<StudentFacultate>();
        List<Profesor> ListaProfesori = new List<Profesor>();
        List<Materie> ListaMaterii = new List<Materie>();

        public Secretariat(List<StudentFacultate> ListaStudenti, List<Profesor> ListaProfesori, List<Materie> ListaMaterii)
        {
            this.ListaStudenti = ListaStudenti;
            this.ListaProfesori = ListaProfesori;
            this.ListaMaterii = ListaMaterii;
 
        }

        public List<Profesor> getProfList
        {
            get { return ListaProfesori; }
        }

        public List<Materie> getMateriiList
        {
            get { return ListaMaterii; }
        }

        public List<StudentFacultate> getStudentsList
        {
            get { return ListaStudenti; }
        }
    }
}
