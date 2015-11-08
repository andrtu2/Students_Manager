using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassUniversitateSiFacultate;
using ClassStudent;
using ClassSecretariat;
using ClassProfesor;
using ClassMaterie;

namespace ClassInitialization
{
    public class Initialization
    {

        public List<Facultate> getListFacultati()
        {
            CitesteFacultati readFile = new CitesteFacultati();
            var lista = readFile.Read();
            return lista;
        }
    }

    public class CitesteFacultati
    {
        public List<Facultate> Read()
        {
            List<Facultate> lista = new List<Facultate>();

            string[] lines = System.IO.File.ReadAllLines("Facultati.txt");         
            foreach (string line in lines)
            {
                Facultate fac = new Facultate(line,new Secretariat(new List<StudentFacultate>(),new List<Profesor>(),new List<Materie>()));
                lista.Add(fac);
            }
            return lista;
        }
    }
}
