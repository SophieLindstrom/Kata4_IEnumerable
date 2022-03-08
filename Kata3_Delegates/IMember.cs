using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata3_Delegates
{
    public enum MemberLevel { Platinum, Gold, Silver, Blue}
    interface IMember: IEquatable<IMember>, IComparable<IMember>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MemberLevel Level {get; set;}
        public DateTime Since { get; set; }

        public string[] Benefits { get; set; }
        public void RandomInit();
    }

 
}
