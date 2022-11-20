namespace Assoziation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
            var fan1 = new Fan(); 
            var fan2 = new Fan();
            var fan3 = new Fan();

            var star = new Star();

            //star.AddFan(fan1);
            //star.AddFan(fan2);
            //star.AddFan(fan3);

            fan1.Star = star;
            fan2.Star = star;
            fan3.Star = star;

            Vater fritz = new Vater();
            Kind hansli = new Kind();

            fritz.Kind = hansli;
            hansli.Vater = fritz;

            Hund fido = new Hund();
            Hund monti = new Hund();

            Laus laus1 = new Laus(fido);
            Laus laus2 = new Laus(fido);
            Laus laus3 = new Laus(monti);

            fido.AddParasit(laus1); 
            fido.AddParasit(laus2);

            laus3.Wirt = monti;

            Kunde meier = new Kunde();
            Kunde mueller = new Kunde();

            Buch cSharp = new Buch();
            Buch java = new Buch();

            meier.Leiht(java);
            mueller.Leiht(java);

            Schulhaus schulhaus = new Schulhaus();
            schulhaus.AddZimmer();
            schulhaus.AddZimmer();

            Zimmer zimmer = new Zimmer();

            Kunde kunde1 = new Kunde();
            kunde1.Name = "Meier";
            kunde1.Vorname = "Fritz";
            kunde1.Umsatz = 9284.25; 
            */

            Person person1 = new Person(); 
            Kunde kunde1 = new Kunde();
            Lagerist lagerist1 = new Lagerist();

            person1.Vorname = "Max";
            person1.Name = "Muster";

            kunde1.Vorname = "Max";
            kunde1.Name = "Muster";
            kunde1.Umsatz = 100.10;

            lagerist1.Vorname = "Max";
            lagerist1.Name = "Muster";
            lagerist1.Groesse = 185; 


        }
    }
    /*
    #region undirektionale Navigierbarkeit
    public class Fan
    {

        public Star Star { get; set; }
    }
    public class Star
    {
        //Array: private Fan[] fans = new Fan[100];
        private List<Fan> fans = new List<Fan>(); 

        public void AddFan(Fan fan); 
            this.fans.Add(fan); 
    }
    #endregion
    #region bidirektionale Navigierbarkeit 1 - 1
    public class Vater
    {
        public Kind Kind { get; set; }
    }

    public class Kind { 
        public Vater Vater { get; set; }
    }
    #endregion
    #region bidrektionale Navigierbarkeit 1 - 0..*
    public class Hund
    {   // 0..*
        private List<Laus> parasiten = new List<Laus>();

        public void AddParasit(Laus parasit)
        {
            parasiten.Add(parasit);
        }
    }

    public class Laus
    {   // private Property mit Wert via Konstruktor = genau 1..1
        public Hund Wirt { get; set; }

        public Laus(Hund wirt)
        {
            this.Wirt = wirt;
            Wirt.AddParasit(this); 
        }
        
    }

    #endregion
    #region undirektionale Navigierbarkeit
    public class Kunde
    {
        private List<Buch> buecher = new List<Buch>(); 

        public void Leiht(Buch buch)
        {
            buecher.Add(buch);
            if (!buch.IstAusgeliehen)
            {
                buecher.Add(buch);
                buch.IstAusgeliehen = true; 
            } else
            {
                Console.WriteLine("Buch ist bereits ausgeliehen.");
            }
        }

        public void Retourniert(Buch buch)
        {
            if(this.buecher.Contains(buch))
            {
                this.buecher.Remove(buch);
                buch.IstAusgeliehen = false; 
            }
        }
    }

    public class Buch
    {
        public bool IstAusgeliehen { get; set; }

    }


    #endregion
    #region Aggregation
    public class Notebook
    {
        private Festplatte festplatte { get; set; }

        public Notebook(Festplatte festplatte)
        {
            if (!festplatte.IstEingebaut)
            {
                this.Festplatte = festplatte;
                festplatte.IstEingebaut = true;
            } else
            {
                throw new Exception("Festplatte bereits eingebaut."); 
            }
        }
    }

    public class Festplatte
    {
        public bool IstEingebaut { get; set; }   
    }
    #endregion
    #region Komposition
    public class Schulhaus
    {
        private List<Zimmer> zimmerList = new List<Zimmer>(); 

        public Schulhaus()
        {
            this.zimmerList.Add(new Zimmer());
        }

        public void AddZimmer()
        {
            this.zimmerList.Add(new Zimmer()); 
        }
        public void AddZimmer(Zimmer zimmer)
        {
            this.zimmerList.Add(zimmer); 
        }

        public class Zimmer
        {
            private Zimmer()
            {
               
            }

            public Zimmer(Schulhaus schulhaus)
            {
                schulhaus.AddZimmer(this);
            }
        }
    }
    #endregion
    
    #region Generalisierung
    // : Entspricht "Vererbung" - Heisst er nimmt die Daten von Person in diesem Beispiel
    public class Person
    {
        public string Name { get; set; }

        public string Vorname { get; set; }

        public void Essen()
        {
            Console.WriteLine("*Essen*"); 
        }
    }
    */
    public class Kunde : Person
    {
        public double Umsatz { get; set; }
    }
    
    public class Lagerist : Person
    {
        public int Groesse { get; set; }
    }






    #endregion
}

