namespace Assignment2;
using static Assignment2.Wizard;
using System.Linq;
public class Queries
{


    public static IEnumerable<string> WizardsByRowling() =>
     from w in WizardCollection.Create()
     where w.Creator is "J.K. Rowling"
     select w.Name;



    public static int FirstSith() =>
        (from w in WizardCollection.Create()
         where w.Name.Contains("Darth")
         orderby w.Year
         select w.Year).First() ?? throw new Exception("No Sith lord could be found");

    public static IEnumerable<(string Name, int? Year)> DistinctHarryPotterCharacters() =>
        (from w in WizardCollection.Create()
         where w.Medium.Contains("Harry Potter")
         select (w.Name, w.Year)).DistinctBy(x => x.Name);

    public static IEnumerable<string> WizardsOrderedByCreator()
    {
        var result = from w in WizardCollection.Create()
                     orderby w.Creator descending, w.Name descending
                     select w.Name;

        var res = result.ToArray();

        foreach (var w in res)
            Console.WriteLine(w);
        return result;

    }



}
