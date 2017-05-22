using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaschenrechnerPlusMinus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int PlusRechnen (int Zahl1, int Zahl2)
        {
            return Zahl1 + Zahl2;
        }

        private int MinusRechnen(int Zahl1, int Zahl2)
        {
            return Zahl1 - Zahl2;
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            buttonPlus.BackColor = Color.Green;
            buttonMinus.BackColor = DefaultBackColor;
          
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            buttonMinus.BackColor = Color.Green;
            buttonPlus.BackColor = DefaultBackColor;
        }

        private void buttonRechnen_Click(object sender, EventArgs e)
        {
            int zahl1;
            int zahl2;

            if (!int.TryParse(textBoxZahl1.Text,out zahl1))
            {
                MessageBox.Show("Die Eingabe der Ersten Zahl war nicht valide.");
            }
            
            if (!int.TryParse(textBoxZahl2.Text, out zahl2))
            {
                MessageBox.Show("Die Eingabe der Zweiten Zahl war nicht valide.");
            }


            if (buttonPlus.BackColor==Color.Green)
            {
                //Addiere Eingabe1 und 2
                int ergebnis = PlusRechnen(zahl1, zahl2);
                labelResult.Text = ergebnis.ToString();
            }
            else if(buttonMinus.BackColor==Color.Green)
            {
                //Subtrahiere Eingabe1 und 2
                int ergebnis = MinusRechnen(zahl1, zahl2);
                labelResult.Text = ergebnis.ToString();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Operation.");
                //Nachricht Ausgeben
            }
        }
    }
}
