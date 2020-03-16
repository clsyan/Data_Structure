using System;
using lista_LDE;

public class NoSentinelaInicio
{
    private NoDuplo proximo;
    public NoDuplo getProximo()
    {
        return this.proximo;
    }
    public void setProximo(NoDuplo elemento)
    {
        this.proximo = elemento;
    }
}