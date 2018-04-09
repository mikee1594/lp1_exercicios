// Solução por João Duarte

using System;
using System.Collections;

namespace LP1Exercises
{

    class Program
    {

        static void Main(string[] args)
        {

            //Cria e inicializa uma nova queue
            Queue myQueue = new Queue();
            //Cria a variavel que vai guardar a string introduzida
            string stringLida = null;
            //Cria a variavel que vai guardar a opcao introduzida
            string temp = null;

            do
            {

                //Mostra o menu e de seguida le a opcao
                Console.WriteLine(
                    "1.Inserir string na fila\n" +
                    "2.Remover string da fila, imprimindo a mesma no ecrã\n" +
                    "3.Listar todas as string existentes na fila\n" +
                    "4.Sair\n");
                temp = Console.ReadLine();

                switch (temp)
                {

                    case "1":
                        Console.WriteLine("Introduza a string:");
                        stringLida = Console.ReadLine();

                        //Insere a string na queue
                        myQueue.Enqueue(stringLida);
                        break;
                    case "2":
                        if (myQueue.Count != 0)
                        {
                            //Imprime a ultima string atraves do metodo
                            //Dequeue() que tambem a elimina
                            Console.WriteLine("A string " + myQueue.Dequeue() +
                                " foi removida");
                        }
                        else
                        {
                            Console.WriteLine("A fila encontra-se vazia.\n");
                        }
                        break;
                    case "3":
                        //Copia todos os elementos da queue para um array
                        //e lista-os
                        foreach (string str in myQueue.ToArray())
                        {
                            Console.Write(str + " ");
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Introduza uma opção válida!");
                        break;
                }

            } while (temp != "4");

            //Indica que o programa terminou
            Console.WriteLine("O programa terminou.");
        }
    }
}
