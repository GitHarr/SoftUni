using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Database
{
    public class Database
    {
        private const int DEFAULT_CAPACITY = 16;

        private int[] values;
        private int currentIndex;

        private Database()
        {
            this.values = new int[DEFAULT_CAPACITY];
            this.currentIndex = 0;
        }

        public Database(params int[] values)
            :this()
        {
            this.InitializeValues(values);
        }

        private void InitializeValues(int[] inputValues)
        {
            try
            {
                Array.Copy(inputValues, this.values, inputValues.Length);
                this.currentIndex = inputValues.Length;
            }
            catch (ArgumentException e)
            {
                throw new InvalidOperationException("Array is full!", e);
            }
        }

        public void Add(int element)
        {
            if (this.currentIndex >= DEFAULT_CAPACITY)
            {
                throw new InvalidOperationException("Array is full!");
            }
            this.values[this.currentIndex] = element;
            this.currentIndex++;
        }

        public void Remove()
        {
            if (this.currentIndex == 0)
            {
                throw new InvalidOperationException("Array is empty");  
            }

            this.currentIndex--;
            this.values[currentIndex] = default(int);
        }

        public int[] Fetch()
        {
            int[] newArray = new int[this.currentIndex];
            Array.Copy(this.values, newArray, this.currentIndex);

            return newArray;
        }
    }
}
