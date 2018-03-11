# Bases de C#

1 - Qual o valor hexadecimal da variável `a` após a execução do seguinte código
C#? E o valor em decimal? Justifica a tua resposta.

```cs
uint a = 0xFEDE;
a &= 0x0F0F;
```

> [Soluções](../solucoes/02_bases_cs/01.md)

2 - Qual o valor hexadecimal da variável `a` após a execução do seguinte código
C#? E o valor em binário? Justifica a tua resposta.

```cs
ulong a = 0xFEDE;
a |= 0x0F0F;
```

> [Soluções](../solucoes/02_bases_cs/02.md)

3 - Qual o valor hexadecimal da variável `a` após a execução do seguinte código
C#? E o valor em decimal? Justifica a tua resposta.

```cs
byte a = 0b1011_1100;
a ^= 0x0F;
```

> [Soluções](../solucoes/02_bases_cs/03.md)

4 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
uint n = uint.MaxValue;
Console.WriteLine(n + 1);
```

> [Soluções](../solucoes/02_bases_cs/04.md)

5 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
int n = -1;
Console.WriteLine(~n);
```

> [Soluções](../solucoes/02_bases_cs/05.md)

6 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
ulong a = 0xABCD;
Console.WriteLine($"{a & 0x000F}");
```

> [Soluções](../solucoes/02_bases_cs/06.md)

7 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
short s = 5 / 2;
Console.WriteLine($"*\t{s}\t*");
```

> [Soluções](../solucoes/02_bases_cs/07.md)

8 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
double x = 3.1223;
Console.WriteLine(@"\\{x}\\:" + x);
```

> [Soluções](../solucoes/02_bases_cs/08.md)

9 - Indica o que é mostrado no ecrã pelo seguinte código C#. Justifica a tua
resposta.

```cs
char c = '\u00AE';
Console.WriteLine($@"\n{c}\n");
```

> [Soluções](../solucoes/02_bases_cs/09.md)

10 - Escreve um programa que leia texto inserido pelo utilizador e de seguida,
o mostre no ecrã. _Sugerido por [Gabriel Nunes](https://github.com/twinventur)._

> [Soluções](../solucoes/02_bases_cs/10.md)

11 - Escreve um programa que solicite ao utilizador dois números inteiros e
apresente a sua soma.

> [Soluções](../solucoes/02_bases_cs/11.md)

12 - Escreve um programa que solicite ao utilizador dois números reais de 64
bits e apresente o resultado do primeiro (base) elevado ao segundo (expoente).
Sugestão: o método [`Math.Pow(x, y)`](https://docs.microsoft.com/pt-pt/dotnet/api/system.math.pow?view=netstandard-2.0#System_Math_Pow_System_Double_System_Double_)
realiza a operação de potenciação _x<sup>y</sup>_.

> [Soluções](../solucoes/02_bases_cs/12.md)

13 - Escreve um programa que leia uma _string_ introduzida pelo utilizador, e de
seguida mostre no ecrã os seus caracteres individuais pela ordem contrária. Por
exemplo, ao ler a _string_ "Ola Mundo!", iria mostrar "!odnuM alO".
*Sugerido por [João Duarte](https://github.com/JoaoAlexandreDuarte)*

> [Soluções](../solucoes/02_bases_cs/13.md)

14 - Escreve um programa que leia uma _string_ introduzida pelo utilizador, e de
seguida mostre no ecrã a(s) letra(s) do meio. Por exemplo, caso seja ímpar, ao
ler a _string_ "12345", iria mostrar "3", no entanto se for par, ao ler a
_string_ "String", iria mostrar "ri".
*Sugerido por [João Duarte](https://github.com/JoaoAlexandreDuarte), adaptado de
codingbat.com/prob/p137729.*

> [Soluções](../solucoes/02_bases_cs/14.md)

15 - Escreve um programa que mostre no ecrã todos os argumentos passados na
linha de comandos.

> [Soluções](../solucoes/02_bases_cs/15.md)

16 - Escreve um programa que solicite ao utilizador três números inteiros e
apresente no ecrã "True" se for possível adicionar dois dos números para obter
o terceiro, ou apresente "False" se não for. Por exemplo, ao receber "1", "2", e
"3" iria mostrar "True" pois é possível somar 1 + 2 para obter 3.
*Sugerido por [João Duarte](https://github.com/JoaoAlexandreDuarte), adaptado de
codingbat.com/prob/p113261.*

> [Soluções](../solucoes/02_bases_cs/16.md)

17 - Escreve um programa que solicite ao utilizador um número inteiro e imprima
o número seguido de um ponto de exclamação. Por exemplo, ao ler o número seis,
vai mostrar no ecrã "6!" . No entanto, se o número for divisível por 3 vai
mostrar "Fizz!", se for divisível por 5 vai mostrar "Buzz!", e se for
divisível por 3 e por 5 mostra "FizzBuzz!" Sugestão: o operador `%` permite
obter o resto da divisão para calcular se é divisível.
*Sugerido por [João Duarte](https://github.com/JoaoAlexandreDuarte), adaptado de
codingbat.com/prob/p115243.*

> [Soluções](../solucoes/02_bases_cs/17.md)

18 - Escreve um programa que solicite ao utilizador a uma frase. Se a respetiva
_string_ tiver mais de 20 caracteres, o programa deve mostrar no ecrã `Too long
to read`. Se a _string_ tiver entre 5 a 20 caracteres, deve mostrar no ecrã
`Ok, if you say so.`. Se a _string_ tiver menos de 5 caracteres, o programa
deve mostrar no ecrã `That's not very meaningful, is it?`.

> [Soluções](../solucoes/02_bases_cs/18.md)

19 - Escreve um programa que solicite ao utilizador dois números reais: o
primeiro deve representar o _high score_ atual num jogo, e o segundo deve
representar o _score_ que o jogador acabou de conseguir. Se o _score_ do
jogador for superior ao _high score_, o programa deve mostrar a mensagem
`New high score!`, caso contrário deve mostrar `Keep trying`. Usa o operador
ternário para implementar o programa.

> [Soluções](../solucoes/02_bases_cs/19.md)

20 - Escreve um programa que sirva como calculadora de linha de comandos,
aceitando três argumentos: 1) a operação a realizar; 2) o primeiro operando; e,
3) o segundo operando. A calculadora deve reconhecer as seguintes operações
indicadas no primeiro argumento: `+`, `-`, `/`, `*` e `**` (sendo que última
representa a operação de potenciação). A calculadora deve realizar a operação
entre os operandos (que se podem assumir como `double`s), mostrar o resultado e
terminar a execução. Se não forem indicados três argumentos, ou se a operação
não for conhecida, o programa deve terminar com uma mensagem de erro
apropriada.

Exemplo de execução: `Calc.exe + 3.2 5`, que deverá mostrar `8.2`.

> [Soluções](../solucoes/02_bases_cs/20.md)

21 - Implementa o programa anterior de forma interativa em ciclo. O programa
deve solicitar a operação e os dois argumentos ao utilizador, apresentar a
o resultado e voltar a fazer novo pedido de operação. O programa deve terminar
apenas quando o utilizador escrever `END` em qualquer uma das solicitações.
Se o programa não reconhecer a operação, deve voltar a pedir a mesma ao
utilizador. Ao terminar, o programa deve indicar ainda quantas operações
realizou.

**Pontos extra:** Como detetar e recuperar de um valor que não seja possível
converter para `double`?

> [Soluções](../solucoes/02_bases_cs/21.md)

22 - Implementa um jogo _turn-based_, com o número máximo de _turns_ dado como
argumento na linha de comando. O jogo deve decorrer em quanto o jogador estiver
vivo e enquanto o número máximo de _turns_ não tiver sido atingido. Em cada
_turn_ o jogador tem uma probabilidade de morrer de 2%. Se o jogador não morrer
numa dada _turn_, deve ser apresentada a mensagem `Player has survided turn #3`
(substituir 3 pela pela _turn_ atual). Contrário, deve ser apresentada a
mensagem `Player died after 10 _turns_` (substituir 10 pela _turn_ em que o
jogador efetivamente morreu).
_Nota 1_: O "jogo" não é interativo, simplesmente apresenta uma mensagem por
_turn_.
_Nota 2_: Podem ser obtidos números aleatórios entre 0 e 1 usando o método
[NextDouble](https://docs.microsoft.com/pt-pt/dotnet/api/system.random.nextdouble)
da classe [Random]:https://docs.microsoft.com/pt-pt/dotnet/api/system.random
(_namespace_ `System`) da seguinte forma:

```cs
// Criar objecto do tipo Random
Random rng = new Random();
// Obter double entre 0 e 1
double probability = rng.NextDouble()
```
> [Soluções](../solucoes/02_bases_cs/22.md)

23 - Escreve um programa que solicite um número de linhas ao utilizador e
imprima um losango com números indicando o número da linha do losango. Por
exemplo, se o utilizador inserir o número 4, deve ser impresso o seguinte
losango:

```
   1
  222
 33333
4444444
 33333
  222
   1
```

Se o utilizador inserir um valor superior a 9 o programa deve terminar com uma
mensagem de erro.

> [Soluções](../solucoes/02_bases_cs/23.md)

24 - Escreve um programa que aceite dois ou mais números inteiros como
parâmetros na linha de comandos, coloque esses números num _array_ de _int_s e
apresente ao utilizador um menu com as seguintes opções:

1. Obter média dos valores no _array_
2. Obter mediana dos valores no _array_
3. Obter moda dos valores no _array_
4. Obter máximo dos valores no _array_
5. Obter mínimo dos valores _no_array_
6. Sair

O programa deve funcionar em ciclo até o utilizador selecionar a opção 6.

> [Soluções](../solucoes/02_bases_cs/24.md)

25 - Exercício sobre _arrays_ de _arrays_ (em breve).

> [Soluções](../solucoes/02_bases_cs/25.md)

26 - Exercício sobre _arrays_ multidimensionais (em breve).

> [Soluções](../solucoes/02_bases_cs/26.md)

27 - Exercício sobre enumerações (em breve).

> [Soluções](../solucoes/02_bases_cs/27.md)

28 - Exercício sobre _enumeration flags_ (em breve).

> [Soluções](../solucoes/02_bases_cs/28.md)

29 - Exercício teórico sobre métodos (em breve).

> [Soluções](../solucoes/02_bases_cs/29.md)

30 - Métodos: criar documentação XML para o seguinte método (em breve).

```cs
// Em breve
```

> [Soluções](../solucoes/02_bases_cs/30.md)

31 - Exercício prático sobre métodos, reescrever método anterior segundo boas
práticas, nomeadamente apenas um `return` e ciclos sem _break_ ou _continue_
(em breve).

> [Soluções](../solucoes/02_bases_cs/31.md)

32 - Exercício sobre _overloading_ de métodos (em breve).

> [Soluções](../solucoes/02_bases_cs/32.md)

33 - Exercício sobre recursão, indicar o que é impresso (em breve).

> [Soluções](../solucoes/02_bases_cs/33.md)

34 - Temos um triângulo feito de blocos. A primeira linha do triângulo tem 1
bloco, a segunda linha tem 2 blocos, a terceira linha tem 3 blocos, e por ai
fora. Completa o método `Triang`, que, dado o número de linhas, determina
recursivamente (sem ciclos ou multiplicações) o número total de blocos num
triângulo deste tipo. Por exemplo, ao receber o valor 4, o método retorna o
valor 10 correspondente ao número de blocos, como indicado na seguinte figura:

```
*    - 1 bloco
**   - 2 blocos
***  - 3 blocos
**** - 4 blocos
Total 10 blocos
```

De modo a testares o método, cria posteriormente um programa que solicite um
número inteiro ao utilizador, invoque o método `Triang` e imprima no ecrã o
número devolvido.
*Sugerido por [João Duarte](https://github.com/JoaoAlexandreDuarte), adaptado de
codingbat.com/prob/p194781.*

```cs
static int Triangle(int linhas)
{
    // Completar este método
}
```

> [Soluções](../solucoes/02_bases_cs/34.md)
