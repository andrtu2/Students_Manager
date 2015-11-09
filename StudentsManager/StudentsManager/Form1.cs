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
            Initialization Init = new Initialization();
            Universitate Univ = Init.GetInfoFromFilesAndCreatUniversitate();
           
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }




    }
}
