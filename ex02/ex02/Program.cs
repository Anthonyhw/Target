
// Número informado
int num = 1597;

int num1 = 0;
int num2 = 1;
int temp = 0;

Console.WriteLine($"Número procurado: {num}\n");

while (num1 <= num)
{
    num1 = temp + num2;
    temp = num2;
    num2 = num1;

    Console.WriteLine(num1);
    
    if (num1 == num)
    {
        Console.WriteLine("O número se encontra na sequência de Fibonnaci!");
        break;
    }
}

if (num1 != num)
    Console.WriteLine("O número não se encontra na sequência de Fibonnaci!");