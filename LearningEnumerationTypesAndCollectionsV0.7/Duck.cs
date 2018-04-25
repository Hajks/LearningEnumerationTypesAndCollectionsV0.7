using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnumerationTypesAndCollectionsV0._7
{
    class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck duckToCompare) //Used debugger to check how it works. Fair enough.
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return Size + "-centrymetrowa kaczka " + Kind.ToString();
        }
    }

    public enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }
}
