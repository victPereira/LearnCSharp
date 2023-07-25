//Chamar classes e metodos

Random dice = new();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First Roll: {roll1}");
Console.WriteLine($"Second Roll: {roll2}");
Console.WriteLine($"Third Roll: {roll3}");

Console.Write("----------------\n");

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);


Console.Write("----------------\n");


//  Adicione a lógica de decisão ao seu código usando as instruções `if`, `else` e `else if`

Random dado = new();
int rolll1  = dado.Next(1,11);
int rolll2  = dado.Next(1,11);
int rolll3  = dado.Next(1,11);

int total = rolll1 + rolll2 + rolll3;
Console.WriteLine($"Dado roll: {rolll1} +  {rolll1} +  {rolll1} = {total}");

if (total > 14) 
{
    Console.WriteLine("You win!!!");
}
if (total >= 15)
{
    Console.WriteLine("Sorry, you lose :( ");
}

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

//O que é uma expressão booleana?
 string message = "The quick brown fox jumps over tha lazy dog.";
 bool result = message.Contains("dog");
 Console.WriteLine(result);

if ( message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

