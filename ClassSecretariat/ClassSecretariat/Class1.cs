using System;
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
        List<Student> ListaStudenti = new List<Student>();
        List<Profesor> ListaProfesori = new List<Profesor>();
        List<Materie> ListaMaterii = new List<Materie>();

        public Secretariat(List<Student> ListaStudenti, List<Profesor> ListaProfesori, List<Materie> ListaMaterii)
        {
            this.ListaStudenti = ListaStudenti;
            this.ListaProfesori = ListaProfesori;
            this.ListaMaterii = ListaMaterii;
 
        }
    }
}
