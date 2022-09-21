namespace Assignment2.Tests;
using static Assignment2.Wizard;
public class QueriesTests
{
    [Fact]
    public void Wizards_By_Rowling()
    {
        var wizards = WizardCollection.Create();

        var expected = new[] { "Harry Potter", "Harry Potter", "Albus Dumbledore", "Lord Voldemort", "Hermione Granger", "Ron Weasley" };
        var actual = Queries.WizardsByRowling();

        Assert.Equal(expected, actual);
    }




    [Fact]
    public void First_Sith_By_Year()
    {
        var wizards = WizardCollection.Create();

        var expected = 1977;
        var actual = Queries.FirstSith();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Harry_Potter_Characters()
    {
        var wizards = WizardCollection.Create();

        var expected = new[] { ("Harry Potter", 1997), ("Albus Dumbledore", 1997), ("Lord Voldemort", 1997), ("Hermione Granger", 1997), ("Ron Weasley", 1997) };
        var actual = Queries.DistinctHarryPotterCharacters();

        // Assert.Equal(expected, actual);
        actual.Should().BeEquivalentTo(expected);
    }


    [Fact]
    public void Wizards_Ordered_By_Creator_Then_By_Name()
    {
        var wizards = WizardCollection.Create();

        var expected = new[] { "Merlin", "Dr. Strange", "Sauron", "Saruman the White", "Radagast the Brown", "Morgoth", "Gandalf", "Galadriel", "Ron Weasley", "Lord Voldemort", "Hermione Granger", "Harry Potter", "Harry Potter", "Albus Dumbledore", "Darth Vader", "Darth Sidious", "Darth Maul" };
        var actual = Queries.WizardsOrderedByCreator();

        actual.Should().BeEquivalentTo(expected);
    }

}

