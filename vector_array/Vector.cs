using System;
using System.Collections;

namespace vector_array
{
    class Vector:IEnumerable
    {
        private object[] array;
        private int tamanho;
        private int current;
        

        public Vector(int size)
        {
            this.tamanho = size;
            
        }
        public int size()
        {
            return this.tamanho;
        }
        public bool isEmpty()
        {
            return tamanho==0;
        }
        public object elementAtRank(int current)
        {
            try{
            return array[current];
            }
            catch{    
                throw new EIndexOutOfRange("erro de index");
            } 
        }
        public object replaceAtRank(int index, object obj)
        {
            if(index < 0 || index >= size())
            {
                throw new EIndexOutOfRange("erro de index");
            }
            object aux = array[index];
            array[index] = obj;
            return aux;
        }
        public void insertAtRank(int index, object obj)
        {
            if(index < 0 || index >= tamanho)
            {
                throw new EIndexOutOfRange("erro de index");
            }
            if (this.current == this.tamanho)
            {
                int newTamanho = this.tamanho * 2;
                object []newArray = new object[newTamanho];
                VectorIterator it = GetEnumerator();
                
                int i=0;

                while(it.MoveNext())
                {
                    Object ob = it.Current;

                    newArray[i] = ob;
                    ob = it.Current;
                    i++;
                }
                array = newArray;
                this.tamanho = newTamanho;
            }
            for (int i = this.current - 1; i >= index; i--)
            {
                array[i+1] = array[i];
            }
            array[index] = obj;
            this.current++;
        }
        public object removeAtRank(int index)
        {
            if(index < 0 || index >= tamanho)
            {
                throw new EIndexOutOfRange("erro de index");
            }
            object aux = array[index];
            for(int i = index; i<this.current - 1; i++)
            {
                array[i] = array[i+1];
            }
            this.current--;
            return aux;
        }

        public VectorIterator GetEnumerator()
        {
            return new VectorIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
