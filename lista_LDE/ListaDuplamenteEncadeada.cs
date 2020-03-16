using System;
using lista_LDE;

class ListaDuplamenteEncadeada
{
    public static void Main(string[] args)
    {
        Lista lista = new Lista();

        Console.WriteLine(
            "1-tamanho\n",
            "2-primeiro\n",
            "3-ultimo\n",
            "4-antes de:",
            "5-depois de:",
            "6-substituir:",
            "7-trocar:",
            "8-inserir antes de:",
            "9-inserir depois de:",
            "10-inserir no inicio:",
            "11-inserir por ultimo:",
            "12-remover:"
            );
            NoDuplo a1 = new NoDuplo(5);
            NoDuplo a2 = new NoDuplo(6);
            NoDuplo a3 = new NoDuplo(7);
            ListIterator it = new ListIterator(lista);


            lista.insertLast(it.search(a1));
            lista.insertFirst(it.search(a2));
            lista.insertAfter(it.search(a2), it.search(a3));
            Console.WriteLine(lista.first());

        /*    
        int op = int.Parse(Console.ReadLine());
        switch(op)
        {
            case 1:
                Console.WriteLine(lista.size());
                break;
            case 2:
                Console.WriteLine(lista.first());
                break;
            case 3:
                Console.WriteLine(lista.last());
                break;
            case 4:
                object n = Console.ReadLine();
                break;
        }
        */    
    }
}