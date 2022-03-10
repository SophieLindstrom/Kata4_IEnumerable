using Kata2b_Immutability;

#region Kata test of Member and MemberList
Console.WriteLine("Create a couple of immutable members");

var member1 = ImmClassMember.Factory.CreateWithRandomData();
Console.WriteLine($"\nmember1 of type {member1.GetType().Name}: {member1}");
var newMember1 = member1.SetFirstName("Karl").SetLastName("Petterson").SetLevel(MemberLevel.Platinum);
Console.WriteLine($"Modified Member from immutable member1: {newMember1}");

var member2 = immRecordMember.Factory.CreateWithRandomData();
Console.WriteLine($"\nmember2 of type {member2.GetType().Name}: {member2}");
var newMember2 = member2 with { FirstName = "Karl", LastName = "Petterson" };
Console.WriteLine($"Modified Member from immutable member2: {newMember2}");

Console.WriteLine("\nCreate a 20 Hilton members of mixed types");
var HiltonMembers = MemberList.Factory.CreateWithRandomData(20); 
HiltonMembers.Sort();
Console.WriteLine(HiltonMembers);

Console.WriteLine("\nCreate a 20 Radisson members of mixed types");
var RadissonMembers = MemberList.Factory.CreateWithRandomData(20);
RadissonMembers.Sort();
Console.WriteLine(RadissonMembers);

Console.WriteLine($"\nHilton member[0]: {HiltonMembers[0]}");
Console.WriteLine($"Radisson member[0]: {RadissonMembers[0]}");
Console.WriteLine();
#endregion

#region For Exercise: Refresh how to generate random initialization data
Console.WriteLine(RandomDate());
Console.WriteLine(RandomCity());

static DateTime RandomDate()
{
    var rnd = new Random();
    while (true)
    {
        try
        {
            int year = rnd.Next(1980, DateTime.Today.Year);
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, 32);

            return new DateTime(year, month, day);
        }
        catch { }
    }
}
static string RandomCity()
{
    var rnd = new Random();
    string[] _cities = "Stockholm Göteborg Malmö".Split(' ');
    return _cities[rnd.Next(0, _cities.Length)];
}
#endregion