using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassSecretariat;
using ClassStudent;

namespace ClassUniversitateSiFacultate
{
    public class Universitate
    {
        string Nume;
        List<Facultate> ListaFacultati = new List<Facultate>();
        List<Student> ListaStudenti = new List<Student>();

        public Universitate(string Nume, List<Facultate> ListaFacultati, List<Student> ListaStudenti)
        {
            this.Nume = Nume;
            this.ListaFacultati = ListaFacultati;
            this.ListaStudenti = ListaStudenti;           
        }
    }

    public class Facultate
    {
        string Nume;
        Secretariat SecretariatulFacultatii;


        public Facultate(string Nume, Secretariat SecretariatulFacultatii)
        {
            this.Nume = Nume;
            this.SecretariatulFacultatii = SecretariatulFacultatii;
        }

        public string _getNume
        {
            get { return Nume; }
           
        }
    }
}
