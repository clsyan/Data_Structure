using System;

namespace lista_LDE_2._0
{
    class Lista
    {
        private int size;
        NoSentinelaFim fim;
        NoSentinelaInicio inicio;
        public Lista()
        {
            size = 0;
            this.fim.setAnterior(null);
            this.inicio.setProximo(null);
        }
        public NoDuplo first()
        {
            return this.inicio.getProximo();
        }
        public NoDuplo last()
        {
            return this.fim.getAnterior();
        }
        /*public NoDuplo before(NoDuplo node)
        {
            
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
