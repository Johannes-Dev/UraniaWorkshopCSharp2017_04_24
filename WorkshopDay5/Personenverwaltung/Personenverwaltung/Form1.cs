using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personenverwaltung
{
    public partial class Form1 : Form
    {
        int maxAnzahlPersonen;
        private Person[] Personen;
        int aktuelleStelle = 0;
        
        public Form1()
        {
            InitializeComponent();
            maxAnzahlPersonen = 100;
            Personen = new Person [maxAnzahlPersonen];
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            Person tempPerson = new Person();
            tempPerson.vorname = textVorname.Text;
            tempPerson.name = textName.Text;
            tempPerson.geburtsdatum = textGeburtstag.Text;

            Personen[aktuelleStelle] = tempPerson;
            aktuelleStelle = aktuelleStelle + 1;
            SetData();

        }


        private void SetData ()
        {
            var tempbinding = new BindingList<Person>(Personen);
            dataGridViewPersonen.DataSource = tempbinding;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult result =  folderBrowserDialogSpeicerPfad.ShowDialog();

            if(result== DialogResult.OK)// hat er auf ok geklickt
            {
                if(Directory.Exists(folderBrowserDialogSpeicerPfad.SelectedPath))
                {

                    int zaehler = 0;

                    string temptext = "";

                    while(Personen[zaehler] != null &&  zaehler < maxAnzahlPersonen )
                    {

                        var zeile = Personen[zaehler].name + ";" +
                            Personen[zaehler].vorname + ";" +
                            Personen[zaehler].geburtsdatum;
                        temptext = temptext + zeile + Environment.NewLine;

                        zaehler = zaehler + 1;
                    }

                    File.WriteAllText(folderBrowserDialogSpeicerPfad.SelectedPath+@"\myfile.csv", temptext);


                }
            }
            
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {


            string loadpfad = "";

            DialogResult result =  openFileDialogLoadPersonen.ShowDialog();

            if (result == DialogResult.OK)// hat er auf ok geklickt
            {
                if(File.Exists(openFileDialogLoadPersonen.FileName))
                {
                    loadpfad = openFileDialogLoadPersonen.FileName;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }

            Personen = new Person[maxAnzahlPersonen];
            aktuelleStelle = 0;

            using (StreamReader sr = File.OpenText(loadpfad))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {

                    var tempdaten = s.Split(';');

                    if(tempdaten.Count()==3)
                    {
                        Person tempPerson = new Person();
                        tempPerson.vorname = tempdaten[0];
                        tempPerson.name = tempdaten[1];
                        tempPerson.geburtsdatum = tempdaten[2];

                        Personen[aktuelleStelle] = tempPerson;
                        aktuelleStelle = aktuelleStelle + 1;
                        
                    }
                }
            }
            SetData();

        }
    }
}
