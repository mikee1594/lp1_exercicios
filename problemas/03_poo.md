# Programação Orientada a Objectos

1 - Escreve um programa em C# que aceite dois inteiros na linha de comandos e
imprima no ecrã cinco números aleatórios cujo valor se situe no intervalo
entre os dois inteiros dados. Usa para o efeito um objecto da classe [Random].

> [Soluções](../solucoes/03_poo/01.md)

---

2 - A classe [Stack] (_namespace_ [System.Collections]) implementa a estrutura
de dados [stack/pilha], na qual a última coisa a ser inserida é a primeira a
ser retirada. Objectos do tipo [Stack] podem ser instanciados com o construtor
simples [Stack()]. O método [Push()] coloca um objeto na pilha, enquanto o
método [Pop()] retira o último objeto lá colocado. O método [Contains()]
verifica se dado objeto existe na pilha.

Cria um programa em C# que apresente um menu ao utilizador com quatro opções:

1. Inserir _string_ na pilha
2. Remover _string_ da pilha, imprimindo a mesma no ecrã
3. Verificar se determinada _string_ existe na pilha
4. Sair

O menu deve ser apresentado em ciclo, e o programa só deve terminar quando o
utilizador selecionar a opção 4.

_Nota:_ A [stack/pilha] aqui referida é a estrutura de dados e não a
_stack_ dos programas onde são locadas as variáveis locais dos métodos e por
ai fora.

> [Soluções](../solucoes/03_poo/02.md)

---

3 - Dá uma vista de olhos na documentação da classe [Math] (_namespace_
[System]). É possível instanciar objetos desta classe? Porquê?

> [Soluções](../solucoes/03_poo/03.md)

---

4 - A classe [Queue] (_namespace_ [System.Collections]) implementa a estrutura
de dados [queue/fila], na qual a primeira coisa a ser inserida é a primeira a
ser retirada. Objectos do tipo [Queue] podem ser instanciados com o construtor
simples [Queue()]. O método [Enqueue()] coloca um objeto no fim da fila,
enquanto o método [Dequeue()] retira o primeiro objeto lá colocado. O método
[ToArray()] copia todos os elementos da fila para um _array_ e devolve esse
_array_.

Cria um programa em C# que apresente um menu ao utilizador com quatro opções:

1. Inserir _string_ na fila
2. Remover _string_ da fila, imprimindo a mesma no ecrã
3. Listar todas as _string_ existentes na fila
4. Sair

O menu deve ser apresentado em ciclo, e o programa só deve terminar quando o
utilizador selecionar a opção 4.

> [Soluções](../solucoes/03_poo/04.md)

---

5 - A classe `Line` tem os seguintes métodos:

```cs
// Cria uma nova instância de Line com as coordenadas indicadas
public Line(double x1, double y1, double x2, double y2);

// Indica se a linha atual cruza com a linha indicada no primeiro argumento
public bool Cross(Line otherLine);
```

Escreve um programa que solicite ao utilizador a informação necessária para
criar duas linhas e depois apresente no ecrã a indicação se as mesmas se
cruzam.

> [Soluções](../solucoes/03_poo/05.md)

---

[Stack]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.stack
[System]: https://docs.microsoft.com/pt-pt/dotnet/api/system
[System.Collections]: https://docs.microsoft.com/dotnet/api/system.collections
[stack/pilha]: https://en.wikipedia.org/wiki/Stack_(abstract_data_type)
[Stack()]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.stack.-ctor#System_Collections_Stack__ctor
[Push()]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.stack.push
[Pop()]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.stack.pop
[Contains()]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.stack.contains
[Random]: https://docs.microsoft.com/pt-pt/dotnet/api/system.random
[Math]: https://docs.microsoft.com/pt-pt/dotnet/api/system.math
[Queue]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.queue
[queue/fila]: https://en.wikipedia.org/wiki/Queue_(abstract_data_type)
[Queue()]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.queue.-ctor#System_Collections_Queue__ctor
[Enqueue()]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.queue.enqueue#System_Collections_Queue_Enqueue_System_Object_
[Dequeue()]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.queue.dequeue#System_Collections_Queue_Dequeue
[ToArray()]: https://docs.microsoft.com/pt-pt/dotnet/api/system.collections.queue.toarray
