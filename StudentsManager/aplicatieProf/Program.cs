using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassStudent;
using ClassMaterie;

namespace aplicatieProf
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class appProf
    {
        private string fileNameProf=null;
        public string cautaStudentiiDeLaMateriaPredata(List<StudentFacultate> listaStudentiFacultate, string materiePredata)
        {
            foreach (StudentFacultate stud in listaStudentiFacultate)
            {

                var listaMateriiStudent = stud.getList;
                foreach (MaterieStudent materie in listaMateriiStudent)
                {
                    if (materie.getNume == materiePredata)
                    {
                        createFileToWriteForProfessor(stud.getNume, materiePredata);
                    }
                }

            }
            return fileNameProf;

        }

        public void createFileToWriteForProfessor(string numeElev, string numeMaterie)
        {
            string text = numeElev + " ";
            numeMaterie += ".txt";
            string FileName = @numeMaterie;

            //  System.IO.File.WriteAllText(numeMaterie, text);
            File.AppendAllText(FileName, numeElev + Environment.NewLine);
            fileNameProf = FileName;

        }
    }
}
