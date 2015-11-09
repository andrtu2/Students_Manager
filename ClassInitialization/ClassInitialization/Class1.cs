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

   /*     public List<Profesor> getListFacultati()
        {

            GetInfoFromFiles();
           CitesteFisier readFile = new CitesteFisier();
   //         var lista = readFile.ReadFac();
            var listaProf = readFile.ReadProf("ARH");
            return listaProf;
        }  */

        public Universitate GetInfoFromFilesAndCreatUniversitate( )
        {
            CitesteFisier file=new CitesteFisier();
            List<string> listaNumeFacultati = file.ReadFac();
            List<Student> listaStudUniv = file.ReadStudentUniv();
            List<Facultate> listaFacultati = new List<Facultate>();
            
            foreach(string numeFac in listaNumeFacultati)
            {
                List<Profesor> listaProfi = file.ReadProf(numeFac);
                List<StudentFacultate> listaStudFacultate = file.ReadStudentFac(numeFac);
                List<Materie> listaMaterii = file.ReadMaterii(numeFac);
                Secretariat sec = new Secretariat(listaStudFacultate, listaProfi, listaMaterii);
                Facultate fac = new Facultate(numeFac, sec);
                listaFacultati.Add(fac);
            }

            Universitate univ = new Universitate("Politehnica Timisoara", listaFacultati, listaStudUniv);

            return univ;

        }


    }

    public class CitesteFisier
    {
      /*  public List<Facultate> ReadFac()
        {
            List<Facultate> lista = new List<Facultate>();

            string[] lines = System.IO.File.ReadAllLines("Facultati.txt");         
            foreach (string line in lines)
            {
                Facultate fac = new Facultate(line,new Secretariat(new List<StudentFacultate>(),new List<Profesor>(),new List<Materie>()));
                lista.Add(fac);
            }
            return lista;
        } */

        public List<string> ReadFac()
        {
            List<string> listaNumeFacultati = new List<string>();
            string[] lines = System.IO.File.ReadAllLines("Facultati.txt");
            foreach (string line in lines)
            {
                listaNumeFacultati.Add(line);
            }
            return listaNumeFacultati;
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

        public List<Student> ReadStudentUniv()
        {
            List<Student> lista = new List<Student>();
            string[] lines = System.IO.File.ReadAllLines("StudentiInscrisiLaUniversitate.txt");
            foreach (string line in lines)
            {
                string[] word= line.Split(' ');
                Student stud = new Student(int.Parse(word[0]), word[1], word[2], int.Parse(word[3]));
                lista.Add(stud);
            }
            return lista;
        }

        public List<StudentFacultate> ReadStudentFac(string Facultate)
        {
            List<StudentFacultate> lista = new List<StudentFacultate>();

            string[] lines = null;
            switch (Facultate)
            {
                case "AC": lines = System.IO.File.ReadAllLines("StudentiInscrisiLaAC.txt"); break;
                case "ETC": lines = System.IO.File.ReadAllLines("StudentiInscrisiLaETC.txt"); break;
                case "ARH": lines = System.IO.File.ReadAllLines("StudentiInscrisiLaARH.txt"); break;
                default: break;
            }

            foreach (string line in lines)
            {
                string[] word = line.Split(' ');
                
                List<MaterieStudent> listaMaterii=new List<MaterieStudent>();
                listaMaterii.Add(new MaterieStudent( word[4] ) );
                listaMaterii.Add(new MaterieStudent( word[5] ) );
                listaMaterii.Add(new MaterieStudent( word[6] ) );
               
                StudentFacultate stud = new StudentFacultate(int.Parse(word[0]), word[1], word[2], int.Parse(word[3]), listaMaterii, bool.Parse(word[7]) );
                lista.Add(stud);
            }


            return lista;
        }

        public List<Materie> ReadMaterii(string Facultate)
        {
            List<Materie> lista = new List<Materie>();

            string[] lines = null;

            switch (Facultate)
            {
                case "AC": lines = System.IO.File.ReadAllLines("MateriiAC.txt"); break;
                case "ETC": lines = System.IO.File.ReadAllLines("MateriiETC.txt"); break;
                case "ARH": lines = System.IO.File.ReadAllLines("MateriiARH.txt"); break;
                default: break;
            }

            foreach (string line in lines)
            {
                Materie mat = new Materie(line);
                lista.Add(mat);
            }

            return lista;
        }
    }
}
