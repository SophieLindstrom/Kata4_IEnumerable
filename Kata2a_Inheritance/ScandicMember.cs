using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2a_Inheritance
{
    internal class ScandicMember :Member
    {
        public override string[] Benefits { get; set; }
        public new void RandomInit()
        {
            base.RandomInit();

            var rnd = new Random();
            Benefits = "SC:Free breakfast, SC:Room upgrade, SC:Two free drinks in the bar".Split(',');
        }

        public ScandicMember()
        {
            RandomInit();
        }

        #region Class Factory for creating an instance filled with Random data
        internal new static class Factory
        {
            internal static IMember CreateWithRandomData()
            {
                var member = new ScandicMember();
                member.RandomInit();
                return member;
            }
        }
        #endregion

    }
}
