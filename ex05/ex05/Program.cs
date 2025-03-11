
// Inserção de string
string input = "Inverta esta string!";

Console.WriteLine($"String original: {input}");


char[] chars = new char[input.Length];

for (int i = chars.Length - 1; i >= 0; i--)
{
    for (int j = chars.Length; j >= chars.Length ;j--)
    {
        chars[(j - 1) - i] = input[i];
    }
}


string output = new string(chars);

Console.WriteLine($"String invertida: {output}");