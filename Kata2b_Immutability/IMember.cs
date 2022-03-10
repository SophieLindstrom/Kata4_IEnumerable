using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2b_Immutability
{
    public enum MemberLevel { Platinum, Gold, Silver, Blue}
    interface IMember: IComparable<IMember>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public MemberLevel Level {get; init; }
        public DateTime Since { get; init; }
    } 
}
