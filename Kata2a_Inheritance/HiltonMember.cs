using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata2a_Inheritance
{
    internal class HiltonMember :Member, IHiltonMember
    {
        public override string[] Benefits { get; set; }
        public new void RandomInit()
        {
            base.RandomInit();

            var rnd = new Random();
            Benefits = "H:Free breakfast, H:Room upgrade, H:Two free drinks in the bar".Split(',');
        }

        public HiltonMember()
        {
            RandomInit();
        }

        #region Class Factory for creating an instance filled with Random data
        internal new static class Factory
        {
            internal static IMember CreateWithRandomData()
            {
                var member = new HiltonMember();
                member.RandomInit();
                return member;
            }
        }
        #endregion

    }
}
