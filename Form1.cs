using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPPProjekat_Novi
{
    public partial class Form1 : Form
    {
        List<KrizniStab> List_KrizniStab = new List<KrizniStab>();
        List<Bolesnik> listaBolesnika = new List<Bolesnik>();
        List<KrizniStab.Bolnica> bolnice = new List<KrizniStab.Bolnica>();
        Bolesnik bolesnik;

        public string PrikazKriznihStabova()
        {
            return List_KrizniStab.Count().ToString();
        }

        public string UkupnoBolesnika()
        {
            return listaBolesnika.Count().ToString();
            }

        public Form1()
        {
            InitializeComponent();
        }
       
        public void button1_Click(object sender, EventArgs e)
        {

            KrizniStab a = new KrizniStab();
            MessageBox.Show("Uspesno ste kreirali Krizni stab.", "Stab za borbu protiv bolesti" );
            List_KrizniStab.Add(a);
            bolnice.Add(new KrizniStab.Bolnica ());
            textBox7.Text = PrikazKriznihStabova();
            textBox3.Text = bolnice.Count().ToString();
        }

        //private void button1_MouseHover(object sender, EventArgs e) {      MessageBox.Show("kreiraj novi stab.");        }

        public void button2_Click(object sender, EventArgs e)
        {
            KrizniStab.Bolnica a = new KrizniStab.Bolnica();
            MessageBox.Show("Uspesno ste kreirali Bolnicu.", "Stab za borbu protiv bolesti");
            bolnice.Add(a);
            textBox3.Text = bolnice.Count().ToString();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            KrizniStab.Bolnica a = new KrizniStab.Bolnica();
            a.Ime= textBox1.Text ;
            a.Prezime = textBox2.Text;
            bolnice.Add(a);
            MessageBox.Show("Uspesno ste kreirali pacijenta:" + a.Ime +" " + a.Prezime, "Stab za borbu protiv bolesti");
            a.DodajBolsenika(a.Ime, a.Prezime, a.Adresa);
            listaBolesnika.Add(a);
            
            textBox8.Text = UkupnoBolesnika();
                            
        }

        //private void textBox1_TextChanged(object sender, EventArgs e){       }

        //private void textBox7_TextChanged(object sender, EventArgs e){        }

        //private void label3_Click(object sender, EventArgs e){      }

        private void button4_Click(object sender, EventArgs e)
        {
            string a = textBox9.Text;
            int b = Convert.ToInt32(a);
            Bolesnik bolesnik = listaBolesnika[b - 1];
            textBox4.Text = bolesnik.Ime;
            textBox5.Text = bolesnik.Prezime;
         

        }

        private void button5_Click(object sender, EventArgs e)
        {
          
            int b = Convert.ToInt32(textBox9.Text);
            bolesnik = listaBolesnika[b - 1];
            if (bolesnik.bolest == 0)
            {
                listBox1.Items.Add("Pacijent je zdrav.");

            }
            else if (bolesnik.bolest == 1)
            {
                listBox1.Items.Add("Pacijent ima blage simptome.");
                listBox2.Items.Add("Caj i supica.");
            }
            else if (bolesnik.bolest == 2)
            {
                listBox1.Items.Add("Pacijent ima tesku klinicku sliku.");
                listBox2.Items.Add("Karantin 14 dana.");
            }
            else if (bolesnik.bolest == 3)
            {
                listBox1.Items.Add("Pacijent ima najtezu klinicku sliku.");
                listBox2.Items.Add("Karantin 28 dana.");

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox9.Text);
            bolesnik = listaBolesnika[b - 1];
            bolesnik.bolest++;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox9.Text);
            bolesnik = listaBolesnika[b - 1];
            bolesnik.bolest++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(textBox9.Text);
            bolesnik = listaBolesnika[b - 1];
            bolesnik.bolest++;
        }
    }
}
