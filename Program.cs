using Unternehmen_SEW;

namespace program
{
    class main
    {
        public static void Main()
        {
            Console.WriteLine("Die Firma Apple:");
            Management[] arbeiter = new Management[4];
            arbeiter[0] = new Putzkraft(46, 111, "Alex", "Putzkraft", "Horn");
            arbeiter[0].AssignAufgabe();
            arbeiter[1] = new Angestellte(-14, 11010, "Jacob", "Angestellte", "Krems");
            arbeiter[1].AssignAufgabe();
            arbeiter[2] = new Ceo(46, 111, "Max", "Ceo", "Horn");
            arbeiter[2].AssignAufgabe();
            arbeiter[3] = new Praktikanten(-14, 11010, "Michael", "Praktikant", "Krems");
            arbeiter[3].AssignAufgabe();
            Firma firma = new Firma("Apple", "Horn", arbeiter);
            Management[] arbeiterFirma = firma.GetArbeiter();
            Console.WriteLine(firma.DisplayWorker());

            Console.WriteLine("");

            Console.WriteLine("Die Firma Amazon:");
            Management[] arbeiter1 = new Management[4];
            arbeiter1[0] = new Putzkraft(46, 111, "Alex", "Putzkraft", "Horn");
            arbeiter1[0].AssignAufgabe();
            arbeiter1[1] = new Angestellte(-14, 11010, "Jacob", "Angestellte", "Krems");
            arbeiter1[1].AssignAufgabe();
            arbeiter1[2] = new Ceo(46, 111, "Max", "Ceo", "Horn");
            arbeiter1[2].AssignAufgabe();
            arbeiter1[3] = new Praktikanten(-14, 11010, "Michael", "Praktikant", "Krems");
            arbeiter1[3].AssignAufgabe();
            Firma firma1 = new Firma("Apple", "Horn", arbeiter);
            Management[] arbeiter1Firma = firma.GetArbeiter();
            Console.WriteLine(firma.DisplayWorker());

            Console.WriteLine("test");
        }
    }
}
