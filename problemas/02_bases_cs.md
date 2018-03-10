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

> [Soluções](../solucoes/02_bases_cs/13.md)

14 - Escreve um programa que leia uma _string_ introduzida pelo utilizador, e de
seguida mostre no ecrã a(s) letra(s) do meio. Por exemplo, caso seja ímpar, ao
ler a _string_ "12345", iria mostrar "3", no entanto se for par, ao ler a
_string_ "String", iria mostrar "ri".

> [Soluções](../solucoes/02_bases_cs/14.md)

15 - Escreve um programa que mostre no ecrã todos os argumentos passados na
linha de comandos.

> [Soluções](../solucoes/02_bases_cs/15.md)

16 - Escreve um programa que solicite ao utilizador três números inteiros e
apresente no ecrã "True" se for possível adicionar dois dos números para obter
o terceiro, ou apresente "False" se não for. Por exemplo, ao receber "1", "2", e
"3" iria mostrar "True" pois é possível somar 1 + 2 para obter 3.

> [Soluções](../solucoes/02_bases_cs/16.md)

17 - Escreve um programa que solicite ao utilizador um número inteiro e imprima
o número seguido de um ponto de exclamação. Por exemplo, ao ler o número seis,
vai mostrar no ecrã "6!" . No entanto, se o número for divisível por 3 vai
mostrar "Fizz!", se for divisível por 5 vai mostrar "Buzz!", e se for
divisível por 3 e por 5 mostra "FizzBuzz!" Sugestão: o operador `%` permite
obter o resto da divisão para calcular se é divisível.

> [Soluções](../solucoes/02_bases_cs/17.md)

18 - Escreve um programa que solicite ao utilizador um número inteiro, que vai
corresponder ao número de linhas de um triângulo feito por blocos, calcule
recursivamente o número total de blocos e de seguida apresente o resultado no
ecrã. Na primeira linha o triângulo tem 1 bloco, na segunda tem 2 blocos, na
terceira tem 3 blocos etc. Por exemplo, ao receber "4", vai calcular 1 + 2 + 3 +
4 e mostrar no ecrã "10".

> [Soluções](../solucoes/02_bases_cs/18.md)