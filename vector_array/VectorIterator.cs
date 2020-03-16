using System;
using System.Collections;

namespace vector_array
{
    class VectorIterator:IEnumerator
    {
        private Vector vetor;
        private int contador;
        public Object Current
        {
            get
            {
                return vetor.elementAtRank(contador);
            }
        }
        public VectorIterator(Vector vetor)
        {
            this.contador=0;
            this.vetor = vetor;
        }


        /*
        public VectorIterator(Vector vetor)
        {
            this.vetor = vetor;
            this.current = 0;
            this.fim = vetor.size() - 1; 
        }
        public Object obj()
        {
            return this.vetor.elementAtRank(current);
        }
        public bool hasNext()
        {
            return this.current <= this.fim;
        }
        public object next()
        {
            object aux = this.vetor.elementAtRank(++current);
            return aux;
        }
        public void reset()
        {
            this.current = 0;
        }
        */

        public bool MoveNext()
        {
            contador++;
            return (this.contador < vetor.size());
        }

        public void Reset()
        {
            this.contador = -1;
        }
    }
}