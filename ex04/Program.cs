Dictionary<string, double> estados = new Dictionary<string, double>();

estados.Add("SP", 67836.43);
estados.Add("RJ", 36678.66);
estados.Add("MG", 29229.88);
estados.Add("ES", 27165.48);
estados.Add("Outros", 19849.53);

var total = estados.Sum(e => e.Value);
Console.WriteLine($"Total: {total}");

foreach (var estado in estados)
{
    Console.WriteLine($"percentual de representação do estado {estado.Key}: {Math.Round((estado.Value/total) * 100, 2)}%");
}

