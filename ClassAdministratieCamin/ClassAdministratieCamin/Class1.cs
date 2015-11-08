using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace ClassAdministratieCamin
{
    public class AdministratieCamin
    {
        List<StudentCamin> listaStudenti = new List<StudentCamin>();

        public AdministratieCamin(List<StudentCamin> listaStudenti)
        {
            this.listaStudenti = listaStudenti;
        }
    }
}
