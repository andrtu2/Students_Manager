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

        public List<Profesor> getListFacultati()
        {
            CitesteFisier readFile = new CitesteFisier();
            var lista = readFile.ReadFac();
            var listaProf = readFile.ReadProf("ARH");
            return listaProf;
        }
    }

    public class CitesteFisier
    {
        public List<Facultate> ReadFac()
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

        public List<Profesor> ReadProf(string Facultate)
        {
            List<Profesor> lista = new List<Profesor>();
            string[] lines=null;
            switch (Facultate)
            {
                case "AC":  lines = System.IO.File.ReadAllLines("ProfesoriAC.txt"); break;
                case "ETC": lines = System.IO.File.ReadAllLines("ProfesoriETC.txt"); break;
                case "ARH": lines = System.IO.File.ReadAllLines("ProfesoriARH.txt"); break;
                default: break;
            }

            foreach (string line in lines)
            {
               string[] word= line.Split(' ');
               Profesor prof = new Profesor(int.Parse(word[0]),word[1],word[2],int.Parse(word[3]),word[4]);
               lista.Add(prof);
            }
            return lista;
        }
    }
}
