using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassUniversitateSiFacultate;
using ClassStudent;
using ClassMaterie;
using ClassSecretariat;

namespace CalculeazaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class CalculeazaMedia1
    {
        Universitate Politehnica = null;
        public CalculeazaMedia1(Universitate Poli, string NumeFac)
        {
            List<Facultate> lista = Poli.getFacultiesList;
            foreach (Facultate fac in lista)
            {
                if (fac._getNume == NumeFac)
                {
                    Secretariat secr = fac._getSecr;
                    var listaStudenti = secr.getStudentsList;
                    foreach (StudentFacultate stud in listaStudenti)
                    {
                        double medieTotala = 0;
                        int nr_materii = 0;
                        var listaMaterii = stud.getListaMaterii;
                        foreach (MaterieStudent mat in listaMaterii)
                        {
                            medieTotala += mat._media;
                            nr_materii++;
                        }
                        medieTotala = medieTotala / nr_materii;
                        stud._medie = medieTotala;
                    }
 
                }
            }
            Politehnica = Poli;
 
        }
        public Universitate repository
        {
            get { return Politehnica; }
        }
    }
}
