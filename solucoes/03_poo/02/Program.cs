// 2 - A classe Stack (namespace System.Collections) implementa a estrutura
// de dados stack / pilha, na qual a última coisa a ser inserida é a primeira a
// ser retirada. Objectos do tipo Stack podem ser instanciados com o construtor
// simples Stack(). O método Push() coloca um objeto na pilha, enquanto o
// método Pop() retira o último objeto lá colocado.O método Contains()
// verifica se dado objeto existe na pilha.
//
// Cria um programa em C# que apresente um menu ao utilizador com quatro opções:
//
// 1. Inserir string na pilha
// 2. Remover string da pilha, imprimindo a mesma no ecrã
// 3. Verificar se determinada string existe na pilha
// 4. Sair
//
// O menu deve ser apresentado em ciclo, e o programa só deve terminar quando o
// utilizador selecionar a opção 4.
//
// Nota: A stack / pilha aqui referida é a estrutura de dados e não a
// stack dos programas onde são locadas as variáveis locais dos métodos e por
// ai fora.

// Solução por João Duarte

using System;
using System.Collections;

namespace LP1Exercises
{

    class Program
    {

        static void Main(string[] args)
        {

            //Cria e inicializa uma nova stack
            Stack myStack = new Stack();
            //Cria a variavel que vai guardar a string introduzida
            string stringLida = null;
            //Cria a variavel que vai guardar a opcao introduzida
            string temp = null;

            do
            {

                //Mostra o menu e de seguida le a opcao
                Console.WriteLine(
                    "1.Inserir string na pilha\n" +
                    "2.Remover string da pilha, imprimindo a mesma no ecrã\n" +
                    "3.Verificar se determinada string existe na pilha\n" +
                    "4.Sair\n");
                temp = Console.ReadLine();

                switch (temp)
                {
                    case "1":
                        Console.WriteLine("Introduza a string:");
                        stringLida = Console.ReadLine();

                        //Insere a string na stack
                        myStack.Push(stringLida);
                        break;
                    case "2":
                        if (myStack.Count != 0)
                        {
                            //Imprime a ultima string atraves do metodo Pop()
                            //que tambem a elimina
                            Console.WriteLine("A string " + myStack.Pop() +
                                " foi removida");
                        }
                        else
                        {
                            Console.WriteLine("A pilha encontra-se vazia.\n");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Introduza a string:");
                        stringLida = Console.ReadLine();

                        //Verifica se a string existe na stack e imprime
                        //uma mensagem correspondente
                        Console.WriteLine(myStack.Contains(stringLida) ?
                            "A string existe na pilha\n" :
                            "A string não existe na pilha\n");
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
