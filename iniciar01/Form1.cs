using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iniciar01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
           
                int nota1, nota2, nota3, nota4, promedio;
                string Situacion;

                nota1 = int.Parse(txt_Nota1.Text);
                nota2 = int.Parse(txt_Nota2.Text);
                nota3 = int.Parse(txt_Nota3.Text);
                nota4 = int.Parse(txt_Nota4.Text);

                promedio = (nota1 + nota2 + nota3 + nota4) / 4;
                txt_promedios.Text = promedio.ToString();

                if (promedio >= 70)
                {
                    Situacion = "aprovado";
                    txt_promedios.ForeColor = Color.Green;
                    txt_situaciones.ForeColor = Color.Green;
                }
                else
                {
                    Situacion = "reprodado";
                    txt_promedios.ForeColor = Color.Red;
                    txt_situaciones.ForeColor = Color.Red;
                }
                txt_situaciones.Text = Situacion;
            }

        private void btn_Salirr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiarr_Click(object sender, EventArgs e)
        {
            txt_Nota1.Clear();
            txt_Nota2.Clear();
            txt_Nota3.Clear();
            txt_Nota4.Clear();
            txt_promedios.Clear();
            txt_situaciones.Clear();
        }
    }
    }

