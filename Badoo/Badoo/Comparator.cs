using System.Collections;
using System.Collections.Generic;
namespace Badoo
{
    public class Comparator : IComparer<Girl>
    {

        public int Compare(Girl x, Girl y)
        {
            var res = x._age.CompareTo(y._age);
            return res;
        }
    }
}