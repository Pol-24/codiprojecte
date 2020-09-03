using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 Registre = new Class2();
            Registre.Nom = label1.Text;
            Registre.Correu = label2.Text;
            Registre.Telèfon = label3.Text;

            int resultado = Class3.Afegir(Registre);

            if (resultado > 0)
            {
                MessageBox.Show("Dades Guardades Correctament", "Dades Guardades", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("No s'han pogut guardar les dades", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        } 

    }

}
