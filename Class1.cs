using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OPPProjekat_Novi
{
    class KrizniStab : IKucnired
    {
        string adresa { get; set; }
        int telefon { get; set; }

        public KrizniStab()
        {
            adresa = "Zmaj Jovina broj 1";
            telefon = 333444;
            Bolnica a = new Bolnica();
        }
               

        public void Kucnired()
        {
            Console.WriteLine("Mole se svi da nose maske.");

        }

        public static void Javnoobavestenje()
        {
            Console.WriteLine("Mole se svi gradjani da postuju odluke kriznog staba.");

        }

        public void PrintOsnovnihPodataka()
        {
            Console.WriteLine("Adresa staba je: {0}", adresa);
            Console.WriteLine("Telefon staba je: {0}", telefon);
            

        }

        public void DodajBolnicu(string adresa, int telefon)
        {
            Bolnica a = new Bolnica(adresa, telefon);
           
        }


        public class Bolnica : Bolesnik, IKucnired
        {
            new string adresa { get; set; }
            int telefon { get; set; }
            public List<Bolesnik> listaBolesnika = new List<Bolesnik>();

            public Bolnica()
            {
                adresa = "Zmaj Jovina broj 1";
                telefon = 111222;
            }

            public Bolnica(string adresa, int telefon)
            {
                this.adresa = adresa;
                this.telefon = telefon;
            }

            public void Kucnired()
            {
                Console.WriteLine("Mole se svi da nose maske.");

            }

            public void DodajBolsenika(string ime, string prezime, string adresa)
            {
                Bolesnik a = new Bolesnik(ime, prezime, adresa);
                listaBolesnika.Add(a);
            }

            public string UkupnoBolesnika()
            {
                return listaBolesnika.Count().ToString();
            }

            public override void Stampanjepodataka()
            {
                Console.WriteLine("Adresa bolnice je: {0}", adresa);
                Console.WriteLine("Telefon bolnice je: {0}", telefon);
                Console.WriteLine("Broj trentnih pacijenata je: {0}", listaBolesnika.Count);


            }



        }

    }

}