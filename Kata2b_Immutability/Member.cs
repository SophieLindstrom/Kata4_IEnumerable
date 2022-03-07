using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2b_Immutability
{
    record Member (string FirstName, string LastName, MemberLevel Level, DateTime Since) : IMember
    {

        #region Implement IComparable
        public int CompareTo(IMember other)
        {
            if (Level != other.Level)
                return Level.CompareTo(other.Level);

            if (LastName != other.LastName)
                return LastName.CompareTo(other.LastName);

            if (FirstName != other.FirstName)
                return FirstName.CompareTo(other.FirstName);
            
            return Since.CompareTo(other.Since);
        }
        #endregion

        public override string ToString() => $"{FirstName} {LastName} is a {Level} member since {Since.Year}";


        #region Class Factory for creating an instance filled with Random data
        internal static class Factory
        {
            internal static Member CreateWithRandomData()
            {
                var rnd = new Random();
                while (true)
                {
                    try
                    {
                        int year = rnd.Next(1980, DateTime.Today.Year + 1);
                        int month = rnd.Next(1, 13);
                        int day = rnd.Next(1, 31);

                        var since = new DateTime(year, month, day);
                        var level = (MemberLevel)rnd.Next((int)MemberLevel.Platinum, (int)MemberLevel.Blue + 1);

                        string[] _firstnames = "Fred John Mary Jane Oliver Marie".Split(' ');
                        string[] _lastnames = "Johnsson Pearsson Smith Ewans Andersson".Split(' ');

                        var firstname = _firstnames[rnd.Next(0, _firstnames.Length)];
                        var lastname = _lastnames[rnd.Next(0, _lastnames.Length)];

                        var member = new Member (firstname, lastname, level, since);

                        return member;
                    }
                    catch { }
                }
            }
        }
        #endregion
    }
}
