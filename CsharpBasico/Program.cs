int idade = 23;
int idadePai = 49;
Console.WriteLine(idade + idadePai);


string FirstName = "Victor";
int idadeVictor = 23;
Console.WriteLine(FirstName + " tem " + (idadeVictor + 7) + " anos ");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

/* 

+ é o operador de adição
- é o operador de subtração
* é o operador de multiplicação
/ é o operador de divisão

*/

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");


/* 

E se você não estiver trabalhando com valores literais? Em outras palavras, e se você precisar dividir duas variáveis do tipo int, 
mas não quiser que o resultado seja truncado? Nesse caso, você deve executar uma conversão de tipo de dados de intpara decimal. 
Casting é um tipo de conversão de dados que instrui o compilador a tratar temporariamente um valor como se fosse um tipo de dados diferente.

Para converter intpara decimal, você adiciona o operador de conversão antes do valor. 
Você usa o nome do tipo de dados entre parênteses na frente do valor para lançá-lo. 
Nesse caso, você adicionaria (decimal)antes das variáveis firste second.

*/

int first = 7;
int second = 5;
decimal quantidade = (decimal)first / (decimal)second;
Console.WriteLine(quantidade);



/*

Ordem de operações
Conforme você aprendeu no exercício anterior, você pode usar os ()símbolos como a ordem dos operadores de operações.
No entanto, esta não é a única maneira de determinar a ordem das operações.

Em matemática, PEMDAS é um acrônimo que ajuda os alunos a lembrar a ordem das operações. A ordem é:

Parênteses (o que estiver dentro dos parênteses é executado primeiro)
E xpoentes
M ultiplicação e D ivisão (da esquerda para a direita)
Adição e subtração (da esquerda para a direita)

*/

