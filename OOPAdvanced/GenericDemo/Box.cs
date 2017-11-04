using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Box<T>
    {
        private IList<T> data;
        private int counter => this.data.Count;

        public Box()
        {
            this.data = new List<T>();
        }
        public int Counter
        {
            get { return this.counter; }
           
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }
        public T Remove()
        {
            T removedElement = data.LastOrDefault();
            this.data.RemoveAt(data.Count - 1);
            return removedElement;
        }
    }
}
