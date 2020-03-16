using System;

namespace lista_LDE_2._0
{
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
}