using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Classes
{
    interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
