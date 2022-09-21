namespace Assignment2;

public static class Extensions
{

    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> source) => source.SelectMany(x => x).ToList();
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> filter) => source.Where(filter);

    public static bool IsSecure(this Uri uri) => uri.Scheme == "https";

    public static int WordCount(this string input) => input.Split(new char[] { ' ', ',', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;

    public static IEnumerable<string> WizardsByRowlingExtension(this IEnumerable<Wizard> wizards) =>
        wizards.Where(w => w.Creator == "J.K. Rowling").Select(w => w.Name);

    public static int FirstSithExtension(this IEnumerable<Wizard> wizards) =>
        wizards.Where(w => w.Name.Contains("Darth"))
        .OrderBy(w => w.Year)
        .First().Year
        ?? throw new Exception("No Sith lord could be found");

    public static IEnumerable<(string Name, int? Year)> DistinctHarryPotterCharactersExtension(this IEnumerable<Wizard> wizards) =>
        wizards.Where(w => w.Medium.Contains("Harry Potter"))
        .Select(w => (w.Name, w.Year))
        .DistinctBy(x => x.Name);

    public static IEnumerable<string> WizardsOrderedByCreatorExtension(this IEnumerable<Wizard> wizards) =>
        wizards.OrderByDescending(w => w.Creator)
        .ThenByDescending(w => w.Name)
        .Select(w => w.Name);



}
