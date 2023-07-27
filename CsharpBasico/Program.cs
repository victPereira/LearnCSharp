//Chamar classes e metodos


//Instanciar = nomear a classe
Random dice = new();


//Chamar o metodo .next da classe Random
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);


//Imprimir no console as 3 variaveis
Console.WriteLine($"First Roll: {roll1}");
Console.WriteLine($"Second Roll: {roll2}");
Console.WriteLine($"Third Roll: {roll3}");


//Quebra de linha
Console.Write("----------------\n");


//Chamando metodo max da clsse Math, passando 2 parametros obrigatorios 
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);


Console.Write("----------------\n");


//  Adicionando a lógica de decisão ao seu código usando as instruções `if`, `else` e `else if`

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


//gerado dias de inscriçoes aleatorio, chamando o metodo .Next da classe Random, usando Else if
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


//Declarando Matrizes 

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");