using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Classes
{
    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        // Gets first item
        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        public Item Last()
        {
            _current = 8;
            return _collection[_current] as Item;
        }
        // Gets next item
        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as Item;
            else
                return null;
        }

        public Item Back()
        {
            //if(_current > 1)
            _current -= _step;
            
            if (!IsDone2)
                return _collection[_current] as Item;
            else
                return null;
        }

        // Gets or sets stepsize
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Gets current iterator item
        public Item CurrentItem
        {
            get { return _collection[_current] as Item; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }

        public bool IsDone2
        {
            get { return _current < 0; }
        }
    }
}

