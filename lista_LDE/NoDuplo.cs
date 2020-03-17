using System;

namespace lista_LDE
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
        public NoDuplo()
        {

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
        public virtual void setAnterior(NoDuplo node)
        {
            this.anterior = node;
        }
        public NoDuplo getProximo()
        {
            return this.proximo;
        }
        public virtual void setProximo(NoDuplo prox)
        {
            this.proximo = prox;
        }
    }
}
