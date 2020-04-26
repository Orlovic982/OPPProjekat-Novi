using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPProjekat_Novi
{
    public class Bolesnik
    {

        string ime;
        string prezime;
        string adresa;
        public int bolest = 0;

        public Bolesnik()
        {
            ime = "prazno";
            prezime = "prazno";
            adresa = "prazno";
        }



        public Bolesnik(string ime, string prezime, string adresa)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
        }


        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
            }

         }

        public string Prezime
        {
            get { return prezime; }
            set
            {
                prezime = value;
            }

        }

        public string Adresa
        {
            get { return adresa; }
            set
            {
                adresa = value;
            }

        }

        public string ImePacijenta()
        {
            return ime;
        }

        public string PrezimePacijenta()
        {
            return prezime;
        }

        public string AdresaPacijenta()
        {
            return adresa;

        }

        public void BolUGrudima()
        {
            bolest++;
        }

        public void PovisenaTempretura()
        {
            bolest++;
        }

        public void BolUGrlu()
        {
            bolest++;
        }

        public void ZdravstveniKartonPacijenta()
        {
            Console.WriteLine("Ime pacijenta: {0}", ime);
            Console.WriteLine("Prezime pacijenta: {0}", prezime);
            Console.WriteLine("Adresa pacijenta: {0}", adresa);
            if (bolest == 0)
            {
                Console.WriteLine("Preporuka lekara: pacijent je zdrav.");

            }
            else if (bolest == 1)
            {
                Console.WriteLine("Preporuka lekara: karantin 14 dana.");
            }
            else if (bolest == 2)
            {
                Console.WriteLine("Preporuka lekara: karantin 28 dana.");
            }
            else if (bolest == 3)
            {

                Console.WriteLine("Preporuka lekara: karantin 42 dana.");
            }
            else
            {
                Console.WriteLine("Preporuka lekara: pacijenta vratiti kuci.");
            }
        }

        public virtual void Stampanjepodataka()
        {

            Console.WriteLine("Ime pacijenta: {0}", ime);
            Console.WriteLine("Prezime pacijenta: {0}", ime);
            Console.WriteLine("Adresa pacijenta: {0}", ime);

        }





    }

}
