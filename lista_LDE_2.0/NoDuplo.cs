using System;

namespace lista_LDE_2._0
{
    public class NoDuplo
    {
        private Object elemento;
        private NoDuplo anterior;
        private NoDuplo proximo;
        public NoDuplo(object elemento)
        {
            this.elemento = elemento;
        }
        public Object getElemento()
        {
            return this.elemento;
        }
        public void setElemento(object elemento)
        {
            this.elemento = elemento;
        }
        public NoDuplo getAnterior()
        {
            return this.anterior;
        }
        public void setAnterior(NoDuplo node)
        {
            this.anterior = node;
        }
        public NoDuplo getProximo()
        {
            return this.proximo;
        }
        public void setProximo(NoDuplo prox)
        {
            this.proximo = prox;
        }
    }
}
