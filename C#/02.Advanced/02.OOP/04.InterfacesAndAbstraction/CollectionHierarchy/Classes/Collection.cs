using System;
using System.Collections.Generic;
using System.Text;
using CollectionHierarchy.Interfaces;

namespace CollectionHierarchy.Classes
{
    public abstract class Collection : IAdd
    {
        private List<string> list;

        public Collection()
        {
            this.list = new List<string>();
        }

        protected IList<string> List
        {
            get
            {
                return this.list;
            }
        }

        public abstract int Add(string element);
    }
}
