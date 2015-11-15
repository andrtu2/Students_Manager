using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassUniversitateSiFacultate;
using ClassStudent;
using ClassProfesor;
using ClassSecretariat;
using ClassMaterie;
using aplicatieProf;
using System.Diagnostics;
using VerificareDacaSituatiaEsteIncheiata;

namespace Autentificare
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class AutentificareClass
    {
        string fileNameProf = null;
        public AutentificareClass(string aut,string numeFacultate,string numeAutentificator, Universitate Poli)
        {
            switch (aut)
            {
                case "profesor": 
                                bool LogInSucccesfull = false;
            List<Facultate> listaFacultati=new List<Facultate>();
            listaFacultati = Poli.getFacultiesList;
            foreach (Facultate fac in listaFacultati)
            {
                if (fac._getNume == numeFacultate)
                {
                    var Secretariat = fac._getSecr;
                    var listaProfesori = Secretariat.getProfList;
                    var listaMaterii = Secretariat.getMateriiList;
                    var listaStudentiFacultate = Secretariat.getStudentsList;

                    foreach (Profesor prof in listaProfesori)
                    {
                        if (prof.getNumeProf == numeAutentificator)
                        {
                            LogInSucccesfull = true;
                            appProf a = new appProf();
                            fileNameProf = a.cautaStudentiiDeLaMateriaPredata(listaStudentiFacultate,prof.getMateriePredata);                        
                            Process.Start(fileNameProf);
                        }
                    }
                }
                    
            }
            if (LogInSucccesfull == false)
            {
   
                
            }
                    break;
                case "secretara":

            List<Facultate> listaFacultati1=new List<Facultate>();
            listaFacultati = Poli.getFacultiesList;
            foreach (Facultate fac in listaFacultati1)
            {
                if (fac._getNume == numeFacultate)
                {
                  /*  var Secretariat = fac._getSecr;
                    VerificareSituatie ver = new VerificareSituatie();                   
                    ver.verificaDacaProfesoriiAuIncheiatSituatia(fac._getNume, fac);
                    SecretariatPtSecretara = Secretariat; */
                }
            }

                    break;
                case "administrator":
                    if (numeAutentificator != null)
                    {
                        ;
                    }
                  
                    break;
            }
 
        }
    }
}
