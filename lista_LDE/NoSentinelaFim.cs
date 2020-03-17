using System;
using lista_LDE;

namespace lista_LDE{

    class NoSentinelaFim:NoDuplo
    {
        private NoDuplo anterior;
        
        public override void setAnterior(NoDuplo ant)
        {
            this.anterior = ant;
        }
    }
}