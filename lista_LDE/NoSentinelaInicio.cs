using System;
using lista_LDE;

namespace lista_LDE
{
    class NoSentinelaInicio:NoDuplo
    {
        private NoDuplo proximo;
        public override void setProximo(NoDuplo node)
        {
            this.proximo = node;
        }
    }
}