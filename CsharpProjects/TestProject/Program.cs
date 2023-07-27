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
int rolll1  = dado.Next(1,7);
int rolll2  = dado.Next(1,7);
int rolll3  = dado.Next(1,7);

int total = rolll1 + rolll2 + rolll3;
Console.WriteLine($"Dado roll: {rolll1} +  {rolll2} +  {rolll3} = {total}");

if ((rolll1 == rolll2) || (rolll2 == rolll3) || (rolll1 == rolll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((rolll1 == rolll2) && (rolll2 == rolll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("Sorry, you lose :( ");
}

Console.Write("----------------\n");

//O que é uma expressão booleana?
 string message = "The quick brown fox jumps over tha lazy dog.";
 bool result = message.Contains("dog");
 Console.WriteLine(result);

if ( message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

Console.Write("----------------\n");


Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Sua subscrição expirou");
}


else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Sua subscrição termina em 1 dia");
    discountPercentage = 20;
}



else if (daysUntilExpiration <= 10)
{
    Console.Write("Your subscription will expire soon. Renew Now!!");
    discountPercentage = 20;
}


if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
}

Console.Write("----------------\n");

// Armazenar e iterar sequencias de dados ao utilizar Matrizes e a instrução FOREACH em C# 

string[] fradulentOrderID = new string[3];
fradulentOrderID[0] = "abc";
fradulentOrderID[0] = "b456";
fradulentOrderID[0] = "c789";

