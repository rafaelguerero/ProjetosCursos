using System;
using System.Collections.Generic;
using System.Text;

namespace PjGenerics
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int count = 0;

        public void AddValue(T value)
        {
            if (count == 10)
            {
                throw new InvalidOperationException("PrintService is full!");
            }
            _values[count] = value;
            count++;
        }

        public T First()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("PrintService is empty!");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (count > 0)
            {
                Console.Write(_values[count - 1]);
            }
            Console.Write("]");
            Console.WriteLine();
            Console.WriteLine("First: " + First());
        }
    }
}
