using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Criando um ArrayList
        ArrayList lista = new ArrayList();

        // Adicionando elementos de diferentes tipos
        lista.Add(10);
        lista.Add("Curso C#");
        lista.Add(3.14);
        lista.Add(true);

        // Acessando elementos
        Console.WriteLine("Elementos do ArrayList:");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        // Removendo um elemento
        lista.Remove(3.14);

        // Inserindo em uma posição específica
        lista.Insert(1, "Novo Elemento");

        Console.WriteLine("\nApós remoção e inserção:");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

        // Tamanho do ArrayList
        Console.WriteLine($"\nTamanho do ArrayList: {lista.Count}");
    }
}