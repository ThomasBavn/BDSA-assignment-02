namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Flatten_ListWithList_1_2_3_4_5__1_2_3_4()
    {
        var list = new List<List<int>>()
        {
            new List<int>() { 1, 2, 3, 4, 5 },
            new List<int>() { 1, 2, 3, 4 }
        };
        var expected = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4 };
        var actual = list.Flatten();
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Flatten_ListWithList_1_2_3_4_5__1_2_3_4_5()
    {
        var list = new List<List<int>>()
        {
            new List<int>() { 1, 2, 3, 4, 5 },
            new List<int>() { 1, 2, 3, 4, 5 }
        };
        var expected = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
        var actual = Extensions.Flatten(list);
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Filter_Divisible_By_7_Greater_Than_42()
    {
        var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 };
        var expected = new List<int>() { 49, 56, 63, 70, 77, 84, 91, 98 };
        var actual = list.Filter(x => x % 7 == 0 && x > 42);
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Filter_Is_Leap_Year()
    {
        int[] list = { 2000, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2037, 2038, 2039, 2040, 2041, 2042, 2043, 2044, 2045, 2046, 2047, 2048, 2049, 2050, 2051, 2052, 2053, 2054, 2055, 2056, 2057, 2058, 2059, 2060, 2061, 2062, 2063, 2064, 2065, 2066, 2067, 2068, 2069, 2070, 2071, 2072, 2073, 2074, 2075, 2076, 2077, 2078, 2079, 2080, 2081, 2082, 2083, 2084, 2085, 2086, 2087, 2088, 2089, 2090, 2091, 2092, 2093, 2094, 2095, 2096, 2097, 2098, 2099, 2100 };
        int[] expected = { 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036, 2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092, 2096 };
        var actual = list.Filter(x => DateTime.IsLeapYear(x));
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void IsSecure_true()
    {
        var uri = new Uri("https://www.google.com");
        var actual = uri.IsSecure();
        actual.Should().BeTrue();
    }

    [Fact]
    public void IsSecure_false()
    {
        var uri = new Uri("http://www.google.com");
        var actual = uri.IsSecure();
        actual.Should().BeFalse();
    }

    [Fact]
    public void WordCount_Hello_world_11()
    {
        var input = "Hello, world!";
        var actual = input.WordCount();
        actual.Should().Be(2);
    }

    [Fact]
    public void Wizards_By_Rowling_Extension()
    {
        var wizards = WizardCollection.Create();

        var expected = new[] { "Harry Potter", "Harry Potter", "Albus Dumbledore", "Lord Voldemort", "Hermione Granger", "Ron Weasley" };

        var actual = wizards.WizardsByRowlingExtension();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void First_Sith_By_Year()
    {
        var wizards = WizardCollection.Create();

        var expected = 1977;
        var actual = wizards.FirstSithExtension();

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Distinct_Harry_Potter_Characters_Extension()
    {
        var wizards = WizardCollection.Create();

        var expected = new[] { ("Harry Potter", 1997), ("Albus Dumbledore", 1997), ("Lord Voldemort", 1997), ("Hermione Granger", 1997), ("Ron Weasley", 1997) };

        var actual = wizards.DistinctHarryPotterCharactersExtension();
        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void Wizards_Ordered_By_Creator()
    {
        var wizards = WizardCollection.Create();

        var expected = new[] { "Merlin", "Dr. Strange", "Sauron", "Saruman the White", "Radagast the Brown", "Morgoth", "Gandalf", "Galadriel", "Ron Weasley", "Lord Voldemort", "Hermione Granger", "Harry Potter", "Harry Potter", "Albus Dumbledore", "Darth Vader", "Darth Sidious", "Darth Maul" };
        var actual = wizards.WizardsOrderedByCreatorExtension();

        actual.Should().BeEquivalentTo(expected);

    }


}
