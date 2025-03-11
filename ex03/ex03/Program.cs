using System.Text.Json;

using (StreamReader r = new StreamReader("Data/dados.json"))
{
    var json = r.ReadToEnd();
    var items = JsonSerializer.Deserialize<List<Faturamento>>(json);

    items!.RemoveAll(i => i.valor == 0);

    var media = items.Average(i => i.valor);

    Console.WriteLine($"Menor valor de faturamento ocorrido em um dia do mês: {items.Min(i => i.valor)}");

    Console.WriteLine($"Maior valor de faturamento ocorrido em um dia do mês: {items.Max(i => i.valor)}");
    
    Console.WriteLine($"Número de dias no mês em que o valor de faturamento diário foi superior à média mensal. {items.Where(i => i.valor > media).Count()}");
}

public class Faturamento
{
    public int dia { get; set; }
    public decimal valor { get; set; }
}