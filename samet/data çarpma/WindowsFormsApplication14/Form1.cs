using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        int[,] matris1=new int[3,3];
        int[,] matris2 = new int[3, 3];
        int[,] sonuc = new int[3, 3];
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView2.Rows.Add();
                
                for (int k = 0; k < 3; k++)
                {
                    matris1[i, k] = rnd.Next(1,10);
                    matris2[i,k]=rnd.Next(1,10);
                    dataGridView1.Rows[i].Cells[k].Value = matris1[i, k];
                    dataGridView2.Rows[i].Cells[k].Value = matris2[i, k];


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                
                dataGridView3.Rows.Add();

                for (int k = 0; k < 3; k++)
                {

                    dataGridView3.Rows[i].Cells[k].Value = matris1[i, k] + matris2[i, k];

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
               
                for (int j = 0; j < 3; j++)
                {
                  
                    for (int k = 0; k < 3; k++)
                    {
                        sonuc[i, j] += matris1[i, k] * matris2[k, j];


                    }
                                
                }
            }
            for (int i = 0; i < 3; i++)
            {
                dataGridView3.Rows.Add();
                for (int j = 0; j < 3; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = sonuc[i, j];
                }
            }

        }
    }
}
