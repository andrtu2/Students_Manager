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
using ClassSecretariat;
using ClassMaterie;
using System.Diagnostics;
using System.IO;


namespace StudentsManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Poli = null;
            fileNameProf = null;
            FacultatePtSecretara = null;
            validate_invalidate_prof_app(false);
            button5.Enabled = false;
        }
        Universitate Poli;
        string fileNameProf;
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
                validate_invalidate_prof_app(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //LogIn profesor Button
            bool LogInSucccesfull = false;
            List<Facultate> listaFacultati=new List<Facultate>();
            listaFacultati = Poli.getFacultiesList;
            foreach (Facultate fac in listaFacultati)
            {
                if (fac._getNume == textBox3.Text)
                {
                    var Secretariat = fac._getSecr;
                    var listaProfesori = Secretariat.getProfList;
                    var listaMaterii = Secretariat.getMateriiList;
                    var listaStudentiFacultate = Secretariat.getStudentsList;

                    foreach (Profesor prof in listaProfesori)
                    {
                        if (prof.getNumeProf == textBox2.Text)
                        {
                            LogInSucccesfull = true;
                            cautaStudentiiDeLaMateriaPredata(listaStudentiFacultate,prof.getMateriePredata);                        
                            Process.Start(fileNameProf);
                        }
                    }
                }
                    
            }
            if (LogInSucccesfull == false)
            {
                MessageBox.Show("Ati introdus numele sau facultatea gresit!");
            }

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

        private void button3_Click(object sender, EventArgs e)
        {
            //insearare note button
        }

        public void createFileToWriteForProfessor(string numeElev,string numeMaterie)
        {
            string text = numeElev + " ";
            numeMaterie += ".txt";
            string FileName = @numeMaterie;

          //  System.IO.File.WriteAllText(numeMaterie, text);
            File.AppendAllText(FileName, numeElev + Environment.NewLine);
            fileNameProf = FileName;

        }

        public void cautaStudentiiDeLaMateriaPredata(List<StudentFacultate> listaStudentiFacultate, string materiePredata)
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
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string NumeFisier = "Materia";
            string filePath = null;
            for (int i = 1; i <= 30; i++)
            {
                string fisier=NumeFisier + i.ToString() + ".txt";
                filePath = @fisier;
                File.Delete(filePath);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {           
            //LogIn secretara Button
            List<Facultate> listaFacultati=new List<Facultate>();
            listaFacultati = Poli.getFacultiesList;
            foreach (Facultate fac in listaFacultati)
            {
                if (fac._getNume == textBox4.Text)
                {
                    var Secretariat = fac._getSecr;
                    verificaDacaProfesoriiAuIncheiatSituatia(fac._getNume, fac);
                    SecretariatPtSecretara = Secretariat;
                }
            }

           

        }

        public void verificaDacaProfesoriiAuIncheiatSituatia(string numeFacultate, Facultate facult)
        {
            string NumeFisier = "Materia";
            string filePath = null;
            int counter = 0;
            int begin = 1;
            int end = 10;
            switch (numeFacultate)
            {
                case "AC": break;
                case "ETC": begin+=10; end+=10; break;
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
                button5.Enabled = true ;
                FacultatePtSecretara = facult;
            }
            else
            {
                MessageBox.Show("Situatia materiilor nu a fost pe deplin incheiata! Nu se poate calcula media studentilor!", "Mesaj important!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
/*
            switch (FacultatePtSecretara._getNume)
            {
                case "AC": break;
                case "ETC": begin += 10; end += 10; break;
                case "ARH": begin += 20; end += 20; break;
                default: break;
 
            }

            var listaStudentiFac = SecretariatPtSecretara.getStudentsList;
            foreach (StudentFacultate stud in listaStudentiFac)
            {
              //  listaMaterii=stud.
          
                  //  string fisier = NumeFisier + i.ToString() + ".txt";
              /*      filePath = fisier;
                    string[] lines = System.IO.File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] word = line.Split(' ');

                    } */
      //      } 
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var listaStudentiFac = SecretariatPtSecretara.getStudentsList;
            foreach (StudentFacultate stud in listaStudentiFac)
            {
                var listaMaterii = stud.getListaMaterii;
                foreach (MaterieStudent materie in listaMaterii)
                {
                    string fisier =materie.getNume + ".txt";
                    string[] lines = System.IO.File.ReadAllLines(fisier);
                    foreach (string line in lines)
                    {
                        string[] word = line.Split(' ');
                        if (word[0] == stud.getNume)
                        {
                            materie._media=double.Parse(word[1]);
                      
                        }
                    }
 
                }
            }

        }

        


    }
}
