using System;
using lista_LDE;

public class NoSentinelaFim
{
    private NoDuplo anterior;
    public NoDuplo getAnterior()
    {
        return this.anterior;
    }
    public void setAnterior(NoDuplo elemento)
    {
        this.anterior = elemento;
    }
}