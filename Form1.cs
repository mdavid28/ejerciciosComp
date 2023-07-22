using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Text;
using System.IO;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private object myStream;
        private object lines;

        public Form1()
        {
            InitializeComponent();
        }

        public object Stream { get; private set; }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            Stream = myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    rtb_archivo.Text = filetext;
                    MessageBox.Show(strfilename);
                }
            }

        }

        private void btn_palabras_Click(object sender, EventArgs e)
        {
            string palabra;
            int contar;

            palabra = rtb_archivo.Text;

            contar = palabra.Length;

            lbl_palabra.Text = "La cantidad de palabras es:" + contar;

        }

        private void btn_lineas_Click(object sender, EventArgs e)
        {
            string v = "";
            string ⦏ ⦐ lines = File.ReadAllLines(rtb_archivo.Text);
            foreach(string line in lines)
            {
                v += "⧵t" + line;

            }
            lbl_lineas.Text = (v);
        }
    }

}