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
using ClassSecretariat;
using ClassMaterie;
using System.Diagnostics;
using System.IO;
using Factory;
using Autentificare;
using CentralizareNote;
using CalculeazaMedia;


namespace StudentsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Poli = null;
            FacultatePtSecretara = null;
            validate_invalidate_prof_app(false);
            validate_invalidate_secretara_app(false);
            validate_invalidate_administrator_app(false);
            button5.Enabled = false;
        }
        Universitate Poli;
        Facultate FacultatePtSecretara;
        Secretariat SecretariatPtSecretara;

        private void button1_Click(object sender, EventArgs e)
        {
            //Init Button
            Initialization Init = new Initialization();
            Universitate Univ = Init.GetInfoFromFilesAndCreatUniversitate();
            Poli = Univ;
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("Profesor" == comboBox1.Text)
            {
                validate_invalidate_prof_app(true);
                validate_invalidate_secretara_app(false);
                validate_invalidate_administrator_app(false);
            }
            if ("Secretara" == comboBox1.Text)
            { 
                validate_invalidate_secretara_app(true);
               validate_invalidate_prof_app(false);
               validate_invalidate_administrator_app(false);
            }
              if ("Administrator Camin" == comboBox1.Text)
              { 
                  validate_invalidate_administrator_app(true); 
               validate_invalidate_secretara_app(false);
               validate_invalidate_prof_app(false);
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            //LogIn profesor Button

            AutentificareClass aut = new AutentificareClass("profesor", textBox3.Text, textBox2.Text,Poli);
     

        }

        public void validate_invalidate_prof_app(bool permission)
        {
            if (permission == true)
                groupBox1.Enabled = true;
            else 
            {
                groupBox1.Enabled = false;
    
            }
            
        }

        public void validate_invalidate_secretara_app(bool permission)
        {
            if (permission == true)
                groupBox2.Enabled = true;
            else
            {
                groupBox2.Enabled = false;

            }

        }

        public void validate_invalidate_administrator_app(bool permission)
        {
            if (permission == true)
                groupBox3.Enabled = true;
            else
            {
                groupBox3.Enabled = false;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //insearare note button
        }


        private void button4_Click(object sender, EventArgs e)
        {

            // Buton folosit doar pentru exemplificarea rularii aplicatiei, nu face parte din tema!
            string NumeFisier = "Materia";
            string filePath = null;
            for (int i = 1; i <= 30; i++)
            {
                string fisier=NumeFisier + i.ToString() + ".txt";
                filePath = @fisier;
                File.Delete(filePath);
            }
            // Buton folosit doar pentru exemplificarea rularii aplicatiei, nu face parte din tema!
        }

        private void button3_Click_1(object sender, EventArgs e)
        {           
            //LogIn secretara Button
            AutentificareClass aut = new AutentificareClass("secretara", textBox5.Text, textBox4.Text, Poli);


           

        }

    

        private void button5_Click(object sender, EventArgs e)
        {
            CalculeazaMedia1 c = new CalculeazaMedia1(Poli, textBox4.Text);
            Poli = c.repository;

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            Centralizare central = new Centralizare(Poli, textBox4.Text);
            Poli=central.Repository;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AutentificareClass aut = new AutentificareClass("administrator", textBox3.Text, "", Poli);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // nu este implementat
        } 

        


    }
}
