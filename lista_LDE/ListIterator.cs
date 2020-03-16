using System;
using lista_LDE;

class ListIterator
{
    NoDuplo current;
    Lista lista;
    public ListIterator(Lista lista)
    {
        this.lista = lista;
        this.current = this.lista.first();
    }
    public object elemento()
    {
        return this.current.getElemento();
    }
    public bool hasNext()
    {
        return this.current.getProximo() != null;
    }
    public NoDuplo search(NoDuplo node)
    {
        while(hasNext())
        {
            if(current == node) return current;
        }
        throw new ListIndexOutOfBondException("o elemento não existe");
    }
}


    