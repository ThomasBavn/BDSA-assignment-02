using System.Collections;
using System.Globalization;
using CsvHelper;

namespace Assignment2;

public record Wizard(string Name, string Medium, int? Year, string Creator);

public class WizardCollection : IEnumerable<Wizard>
{
    private WizardCollection() { }

    public static WizardCollection Create() => new WizardCollection();

    private static Lazy<IReadOnlyCollection<Wizard>> Read { get; } = new Lazy<IReadOnlyCollection<Wizard>>(() =>
    {
        var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Wizards.csv");
        var csv = File.OpenText(file);
        using var reader = new CsvReader(csv, CultureInfo.InvariantCulture);
        return reader.GetRecords<Wizard>().ToList().AsReadOnly();
    });

    public IEnumerator<Wizard> GetEnumerator() => Read.Value.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();



}
