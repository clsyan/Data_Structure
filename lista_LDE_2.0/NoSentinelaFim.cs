using System;
namespace lista_LDE_2._0
{
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
}