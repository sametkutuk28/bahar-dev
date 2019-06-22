using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi_index
{
    public partial class Form1 : Form
    {
        string[] isim = {"samet","polat","cem","mehmet","ali","kerem","mücahit" };
        string[] soyisim = {"kütük","gencer","duvarbaşı","delibas","su","kral","reis" };
        double boy;
        double kilo;
       double index;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
               
                int soy = rnd.Next(0, soyisim.Length);
                int ad = rnd.Next(0, isim.Length);
                dataGridView1.Rows.Add();

                
               
                dataGridView1.Rows[i].Cells[0].Value=isim[ad];
                dataGridView1.Rows[i].Cells[1].Value=soyisim[soy];
               
                


                
            }
            for (int i = 0; i < 10; i++)
            {
                boy = rnd.Next(150, 190);
                kilo = rnd.Next(50,100);
                boy = boy / 100;
                index = kilo / (boy * boy);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[2].Value = kilo;
                dataGridView1.Rows[i].Cells[3].Value = boy;
                dataGridView1.Rows[i].Cells[4].Value = index;


            }

            
        }
    }
}
