using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassStudent;
using ClassProfesor;
using ClassUniversitateSiFacultate;
using ClassInitialization;

namespace StudentsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> listaStudentiUniversitate = new List<Student>();
            //List<Facultate> listaFacultati = new List<Facultate>();

            Initialization Init = new Initialization();
       //     List<Facultate> listaFacultati=Init.getListFacultati();
            List<Profesor> listaprof = Init.getListFacultati();
           List<Facultate> listaFacultati = null;
         //   Init.getListFacultati();

            Universitate Univ = new Universitate("Politehnica Timisoara", listaFacultati, listaStudentiUniversitate);
           
        }
    }
}
