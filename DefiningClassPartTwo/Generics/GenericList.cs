using System;
using System.Collections.Generic;
using System.Linq;


namespace Generics
{
    public class GenericList<T>
    {
        const int DefaultCapacity = 4096;

        private T[] elements;
        private int count = 0;
        private int capasityOld = 0;

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public GenericList(int capacity) 
        {
            if (capacity == 0)
            {
                capacity = DefaultCapacity;
            }
            elements = new T[capacity];
        }

        public void AddElement(T element)
        {
            if (count >= elements.Length)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "The list capacity of {0} was exceeded.", elements.Length));
            }
            this.elements[count] = element;
            this.count++;

        }

        public T ElementByIndex(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T result = this.elements[index];
            return result;
        }

        public void RemoveByIndex(int index)
        {
            if (index >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            elements[index] = elements.ElementAtOrDefault(this.count+1);
            this.count--;
        }

        public void InsertByIndex(T element, int index)
        {
            while (index > elements.Length)
            {
                AutoGrow();
            }
            this.elements[index] = element;
            this.count++;
        }

        public void Clear()
        {
            this.elements = new T[capasityOld];
        }

        public int FindElementByValue(T value)
        {
            int index = -1;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    index = i;
                    break;
                }
                {
                    Console.WriteLine("There is no element with this value = " + value);
                }   
            }
            return index;
        }

        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < this.elements.Length; i++)
            {
                result += this.elements[i].ToString() + " ";
            }
           
            return result;
        }

        public T[] AutoGrow()
        {
            int lenght = this.elements.Length;
            T[] doubledArray = new T[lenght];
            for (int i = 0; i < lenght; i++)
            {
                doubledArray[i] = this.elements[i];
            }

            this.Clear();
            
            this.elements = new T[lenght*2];
            for (int i = 0; i < lenght; i++)
            {
                this.elements[i] = doubledArray[i];
            }

            return this.elements;
        }

        public T Min()
        {
            T minElement = this.elements.Min();
            return minElement;
        }

        public T Max()
        {
            T maxElement = this.elements.Max();
            return maxElement;
        }
    }
}
