using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassUniversitateSiFacultate;
using ClassSecretariat;
using ClassStudent;
using ClassMaterie;
using VerificareDacaSituatiaEsteIncheiata;

namespace CentralizareNote
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Centralizare
    {
        private Universitate Politehnica = null;
        private Secretariat SecretariatPtSecretara = null;
        public Centralizare(Universitate Poli, string NumeFac)
        {
            List<Facultate> listaFacultati = new List<Facultate>();
            listaFacultati = Poli.getFacultiesList;
            foreach (Facultate fac in listaFacultati)
            {
                if (fac._getNume == NumeFac)
                {

                    var Secretariat = fac._getSecr;
                    VerificareSituatie ver = new VerificareSituatie();
                    bool SituatieIncheiata=ver.verificaDacaProfesoriiAuIncheiatSituatia(fac._getNume, fac);
                    SecretariatPtSecretara = Secretariat;
                }
            }



            var listaStudentiFac = SecretariatPtSecretara.getStudentsList;
            foreach (StudentFacultate stud in listaStudentiFac)
            {
                var listaMaterii = stud.getListaMaterii;
                foreach (MaterieStudent materie in listaMaterii)
                {
                    string fisier = materie.getNume + ".txt";
                    string[] lines = System.IO.File.ReadAllLines(fisier);
                    foreach (string line in lines)
                    {
                        string[] word = line.Split(' ');
                        if (word[0] == stud.getNume)
                        {
                            materie._media = double.Parse(word[1]);

                        }
                    }

                }
            }
            Politehnica = Poli;
        }

        public Universitate Repository
        {
            get { return Politehnica; }
        }
    }
}
