using System;
using lista_LDE;

public class Lista
{
    private NoSentinelaInicio inicio;
    private NoSentinelaFim fim;
    private int tamanho;
    public Lista()
    {
        this.tamanho = 0;
    }
    public int size()
    {
        return this.tamanho;
    }
    public Boolean isEmpty()
    {
        return this.size() == 0;
    }
    public Boolean isFirst(NoDuplo node)
    {
        return this.inicio.getProximo() == node;
    }
    public Boolean isLast(NoDuplo node)
    {
        return this.fim.getAnterior() == node;
    }
    public NoDuplo first()
    {
        if(isEmpty())
        {
            throw new EmptyListException("Lista vazia");
        }
        return this.inicio.getProximo();
    }
    public NoDuplo last()
    {

        if(isEmpty())
        {
            throw new EmptyListException("Lista vazia");
        }
        return this.fim.getAnterior();
    }
    public NoDuplo before(NoDuplo node)
    {
        if(isFirst(node))
        {
            throw new ListIndexOutOfBondException("O índice não existe");
        }
        return node.getAnterior();
    }
    public NoDuplo after(NoDuplo node)
    {
        if(isLast(node))
        {
            throw new ListIndexOutOfBondException("O índice não existe");
        }
        return node.getProximo();
    }
    public object replaceElement(NoDuplo node, object valor)
    {
        object aux = node.getElemento();
        node.setElemento(valor);
        return aux;
    }
    public void swapElements(NoDuplo node, NoDuplo node2)
    {
        object aux = node.getElemento();
        node.setElemento(node2.getElemento());
        node.setElemento(aux);
    }
    public void insertBefore(NoDuplo node, NoDuplo node2)
    {
        node2.setProximo(node);
        node2.setAnterior(node.getAnterior());
        node.getAnterior().setProximo(node2);
        node.setAnterior(node2);
        tamanho++;
    }
    public void insertAfter(NoDuplo node, NoDuplo node2)
    {
        node2.setAnterior(node);
        node2.setProximo(node.getProximo());
        node.setProximo(node2);
        tamanho++; 
    }
    public void insertFirst(NoDuplo node)
    {
        node.setProximo(inicio.getProximo());
        node.setAnterior(null);
        inicio.getProximo().setAnterior(node);
        inicio.setProximo(node);
        tamanho++;
    }
    public void insertLast(NoDuplo node)
    {
        
        node.setProximo(null);
        node.setAnterior(fim.getAnterior());
        fim.getAnterior().setProximo(node);
        fim.setAnterior(node);
        tamanho++;
        
    }
    public object remove(NoDuplo node)
    {
        if(isEmpty())
        {
            throw new EmptyListException("lista vazia");
        }
        node.getProximo().setAnterior(node.getAnterior());
        node.getAnterior().setProximo(node.getProximo());
        node.setAnterior(null);
        node.setProximo(null);
        tamanho--;
        return node.getElemento();
    }
}
