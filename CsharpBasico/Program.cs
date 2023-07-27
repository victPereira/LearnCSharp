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

Console.Write("------------------------DESAFIOS notas alunos -------------------\n");

// initialize variables - graded assignments
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
       studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    // initialize/reset a counter for the number of assignment 
    int gradedAssignments = 0;

    // loop through the scores array and complete calculations for currentStudent
    foreach (int score in studentScores)
    {
        // increment the assignment counter
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // add the exam score to the sum
            sumAssignmentScores += score;

        else
            // add the extra credit points to the sum - bonus points equal to 10% of an exam score
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}


Console.Write("------------------------USO DE OPERADOR DE IGUALDADE -------------------\n\n");

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string  myValue = "a";
Console.WriteLine(myValue == "a");	
Console.WriteLine("-----\n");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Metodo que retornam um valor booliano
Console.Write("------Metodo que retornam um valor booliano---\n");
string pangram = "Uma frase nada com nada.";
Console.WriteLine(pangram.Contains("frase"));
Console.WriteLine(pangram.Contains("valor"));

Console.Write("------------------------USO DE OPERADOR CONDICIONAL -------------------\n");
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Console.Write("------------------------DESAFIO CARA OU COROA -------------------\n\n");
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "hrads" : "tails");

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privilegees.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

