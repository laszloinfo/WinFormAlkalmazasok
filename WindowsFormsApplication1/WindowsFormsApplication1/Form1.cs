using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string elsoSor = "";
        List<Versenyzo> VersenyzoLista = new List<Versenyzo>();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("Snooker.txt", Encoding.UTF8))
            {
         
                int osszegez = 0;
                elsoSor = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    /* columnHeader1.Text = elsoSor.Split(';')[0];
                     columnHeader2.Text = elsoSor.Split(';')[1];
                     columnHeader3.Text = elsoSor.Split(';')[2];
                     columnHeader4.Text = elsoSor.Split(';')[3];*/
                    
                    for (int i = 0; i < sor.Split(';').Length; i++)
                    {
                        listView1.Columns[0].Text = elsoSor.Split(';')[i];
                    }
                    int helyezes = Int32.Parse(sor.Split(';')[0]);
                    string nev = sor.Split(';')[1];
                    string orszag =sor.Split(';')[2];
                    int nyeremeny = Int32.Parse(sor.Split(';')[3]);
                    osszegez += nyeremeny;
                    Versenyzo versenyzo = new Versenyzo(helyezes, nev, orszag, nyeremeny);
                    VersenyzoLista.Add(versenyzo);
                    ListViewItem lvi = new ListViewItem(helyezes.ToString());
                    lvi.SubItems.Add(nev);
                    lvi.SubItems.Add(orszag);
                    lvi.SubItems.Add(nyeremeny.ToString());
                    listView1.Items.Add(lvi);
                    bool vanE = true;
                    foreach (var item in comboBox1.Items)
                    {
                        if (item.ToString()==orszag)
                        {
                            vanE = false;
                            break;
                        }
                        
                    }
                    if (vanE)
                    {
                        comboBox1.Items.Add(orszag);
                    }


                } textBox2.Text = $"A versenyzők átlaga {(double)osszegez/listView1.Items.Count:F2}Fontot kerestek";
                
            }
            textBox3.Text = $"A világranglistán {listView1.Items.Count}versenyző szerepel";
            textBox4.Text = $"Helyezés:{ujVersenyzo.Helyezes}"+ "\n\r" $"Név:{ujVersenyzo.nev}"+"\n\r" + $"ország:{ujVersenyzo.orszag}"+"\n\r" $"nyermény összege:{ujVersenyzo.Nyeremeny *380}ft";
            Versenyzo ujVersenyzo = new Versenyzo();
            int maximumkereset = 0;
            foreach (var item in listView1.Items)
            {
                if (item.Nyeremeny >= maximumkereset && item.Orszag == "Kína")
                {

                }
                maximumkereset = item.Nyeremeny;
                ujVersenyzo = item;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            listView1.SelectedItems[0].Remove();
        }

    
        private void levalogat_Click(object sender, EventArgs e)
        {
            int ertek = Int32.Parse(textBox1.Text);
            foreach   (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[2].Text !=comboBox1.SelectedItem.ToString()|| Int32.Parse(item.SubItems[3].Text) <ertek)
                {
                    listView1.Items.Remove(item);
                }

              
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
