using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM_.NET_PracticeTask1
{
    class Vector
    {
        private int[] array;
        private Vector(int size)
        {
            array = new int[size];
        }
        public Vector(IEnumerable<int> collection)
        {
            array = new int[collection.Count()];
            for (int i = 0; i < collection.Count(); i++)
            {
                array[i] = collection.ElementAt(i);
            }
        }
        public Vector(IEnumerable<int> collection, int startIndex, int finalIndex)
        {
            if (startIndex < 0 || 
                startIndex > finalIndex ||
                startIndex >= collection.Count() ||
                finalIndex < 0 || 
                finalIndex >= collection.Count())
            {
                throw new Exception("Exception with startIndex or finalIndex in constructor.");
            }
            array = new int[finalIndex - startIndex + 1];
            for (int i = 0; i <= finalIndex-startIndex; i++)
            {
                array[i] = collection.ElementAt(i + startIndex);
            }
        } 
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Count())
                    throw new Exception("Index is out of range vector.");
                return array[index]; 
            }
            set
            {
                if (index < 0|| index >= array.Count())
                    throw new Exception("Index is out of range vector.");
                array[index] = value; 
            }
        }
        public Vector AddVector(Vector vectToAdd)
        {
            if (this.array.Count() != vectToAdd.array.Count())
            {
                throw new Exception("Adding is failed. Different size of vectors.");
            }

            for (int i = 0; i < this.array.Count(); i++)
            {
                this.array[i] = this.array[i] + vectToAdd.array[i];
            }
            return this;
        }
        
        public Vector SubtractVector(Vector vectorToSubract)
        {
            if (this.array.Count() != vectorToSubract.array.Count())
            {
                throw new Exception("Subtracting is failed. Different size of vectors.");
            }
            
            for (int i = 0; i < vectorToSubract.array.Count(); i++)
            {
                this.array[i] = this.array[i] - vectorToSubract.array[i];
            }
            return this;
        }
        public Vector MultiplyByCoefficient(double coefficient)
        {          
            for (int i = 0; i < this.array.Count(); i++)
            {
                this.array[i] = (int)(this.array[i] * coefficient);
            }
            return this;
        }
        public bool CompareWithVectors(Vector vectorToCompare)
        {
            bool isEqual = true;
            if (this.Size() != vectorToCompare.Size())
            {
                isEqual = false;
                return isEqual;
            }
            for (int i = 0; i < this.Size(); i++)
            {
                if (this[i] != vectorToCompare[i])
                {
                    isEqual = false;
                }
            }
            return isEqual;
        }
        public int Size()
        {
            return array.Count();
        }
        public override string ToString()
        {
            String strVector = "";
            for (int i = 0; i < this.Size(); i++)
            {
                strVector += this[i] + " ";
            }
            return strVector;
        }
    }
}
