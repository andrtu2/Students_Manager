using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassUniversitateSiFacultate;
using System.IO;

namespace VerificareDacaSituatiaEsteIncheiata
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class VerificareSituatie
    {
        public bool verificaDacaProfesoriiAuIncheiatSituatia(string numeFacultate, Facultate facult)
        {
            string NumeFisier = "Materia";
            string filePath = null;
            int counter = 0;
            int begin = 1;
            int end = 10;
            switch (numeFacultate)
            {
                case "AC": break;
                case "ETC": begin += 10; end += 10; break;
                case "ARH": begin += 20; end += 20; break;
                default: break;
            }
            for (int i = begin; i <= end; i++)
            {
                string fisier = NumeFisier + i.ToString() + ".txt";
                filePath = @fisier;

                if (File.Exists(filePath) == true)
                    counter++;
                else
                {
                    counter = 0;

                }
            }
            if (counter == end)
            {
               // button5.Enabled = true;
              //  FacultatePtSecretara = facult;
                return true;
            }
            else
            {
                return false;
               // MessageBox.Show("Situatia materiilor nu a fost pe deplin incheiata! Nu se poate calcula media studentilor!", "Mesaj important!");
            }
        }
    }
}
