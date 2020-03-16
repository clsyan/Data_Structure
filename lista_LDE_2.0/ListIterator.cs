using System;

namespace lista_LDE_2._0
{
    class ListIterator
    {
        NoDuplo current;
        Lista lista;
        public ListIterator(Lista lista)
        {
            this.lista = lista;
            this.current = lista.first();
        }
        public object Object()
        {
            return current.getElemento();
        }
        public bool hasNext()
        {
            return current != lista.last();
        }
        public object nextObject()
        {
            Object aux = current.getProximo().getElemento();
            this.current = this.current.getProximo();
            return aux;
        }
        public void reset()
        {
            current = lista.first();
        }
    }
}