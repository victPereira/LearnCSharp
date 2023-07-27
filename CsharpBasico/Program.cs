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
Console.Write("--------CHAMAR METODO MAX--------\n");


//Chamando metodo max da clsse Math, passando 2 parametros obrigatorios 
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);


Console.Write("---------`if`, `else` e `else if`-------\n");


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

Console.Write("--------EXPRESSAO BOOLEANA--------\n");

//O que é uma expressão booleana?
string message = "The quick brown fox jumps over tha lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if ( message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}


Console.Write("--------GERANDO NUMEROS ALEATORIOS COM UM NOVO METODO --------\n");


//gerado dias de inscriçoes aleatorio, chamando o metodo .Next da classe Random, usando Else if
Random random = new Random();
int daysUntilExpiration = random.Next(12);

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Sua subscrição expirou");
}


else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Sua subscrição termina em 1 dia");
}



else if (daysUntilExpiration <= 10)
{
    Console.Write("Your subscription will expire soon. Renew Now!!");
}


if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
}

Console.Write("--------DECLARANDO MATRIZES--------\n");


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


//Passando a propiedade LENGTh para percorrer e contabilizar quantos itens tem na matriz
//A propriedade Length é uma maneira programática de determinar o número de elementos em uma matriz.
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");


Console.Write("--------USANDO FOREACH--------\n");


// ----------------------------------------------------FOREACH »» ParaCada----------------------------------------------------

// Ele é executado uma vez para cada elemento da matriz "names" 
// O valor armazenado no elemento atual da matriz names será atribuído à variável temporária name para facilitar o acesso dentro do bloco de código.

string[] names = { "Victor", "Julia", "Vinicius"};
foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.Write("------------------------PROJETO ESTOQUE -----------------------\n");

// Criar e inicializar uma matriz de int --------


int[] inventory  = {200, 450, 700, 170, 250};
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.\n");

Console.Write("------------------------DESAFIOS PEDIDOS FRAUDULENTOS -------------------\n");

string[] ids = { "b123", "c234", "a456","c15", "b177", "g3003","g3003","b179"};
foreach (string id in ids)
{
    //O metodo StarsWith faz a ação de puxar só os Ids que começam com a string inserida no parametro
    if (id.StartsWith("b1"))
    {
        Console.WriteLine(ids);
    }
}

