namespace M320_Lidl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Kunde kunde1 = new Kunde(); 
            Lagerist lagerist1 = new Lagerist();

            person1.Vorname = "Peter";
            person1.Name = "Meier";
            kunde1.Vorname = "Fritz";
            kunde1.Name = "Müller";
            kunde1.Umsatz = 5000;
            lagerist1.Vorname = "Hans";
            lagerist1.Name = "Brunner";
            lagerist1.Groesse = 185;
        }
    }
}
