using System;
using System.Collections.Generic;

namespace vector_array
{
    class VectorIterator
    {
        private Vector vetor;
        private int current;
        private int fim;
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
    }
}