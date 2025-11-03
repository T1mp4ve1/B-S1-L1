//Esercizio 1
int N = 10;
int sum = 0;

for (int i = 1; i <= N; i++)
{
    sum += i;
}
Console.WriteLine("Esrcizio 1: " + sum);
//-----------

//Esercizio 2
Console.WriteLine("");
Console.WriteLine("Esrcizio 2:");
int J = 1;

while (J <= 100)
{
    if (J % 2 == 0)
    {
        Console.WriteLine(J);
    }
    J++;
}
//-----------

//Esercizio 3
Console.WriteLine("");
Console.WriteLine("Esrcizio 3:");

int SecretNumber = 7;
int attempt;
int remainingAttempts = 3;

do
{
    Console.Write("Indovina il numero segreto (tra 1 e 10), hai 3 tentativi: ");
    attempt = int.Parse(Console.ReadLine());

    if (attempt == SecretNumber)
    {
        Console.WriteLine("");
        Console.WriteLine("Complimenti! Hai indovinato!");
        Console.WriteLine("");
        break;
    }
    else
    {
        remainingAttempts--;

        if (remainingAttempts > 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Sbagliato! Tentativi rimasti: " + remainingAttempts);
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Hai esaurito i tentativi!");
            Console.WriteLine("");
            break;
        }
    }
}
while (remainingAttempts > 0 && attempt != SecretNumber);
Console.WriteLine("Premi un tasto per uscire...");
Console.ReadKey();
//-----------