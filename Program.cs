using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.OutputEncoding = Encoding.UTF8;

const string endpoint = "https://catfact.ninja/fact";

Console.WriteLine("Iniciando requisição para obter um fato sobre gatos:");
Console.WriteLine();
Console.WriteLine(endpoint);
Console.WriteLine();

using HttpClient client = new();

try
{
    HttpResponseMessage response = await client.GetAsync(endpoint);
    response.EnsureSuccessStatusCode();

    string json = await response.Content.ReadAsStringAsync();

    CatFactResponse? catFact = JsonSerializer.Deserialize<CatFactResponse>(json);

    if (!string.IsNullOrWhiteSpace(catFact?.Fact))
    {
        Console.WriteLine("Fato sobre Gatos:");
        Console.WriteLine(catFact.Fact);
    }
    else
    {
        Console.WriteLine("Não foi possível obter um fato sobre gatos.");
    }
}
catch (HttpRequestException ex)
{
    Console.WriteLine("Erro ao acessar a API.");
    Console.WriteLine($"Detalhes: {ex.Message}");
}
catch (JsonException ex)
{
    Console.WriteLine("Erro ao interpretar os dados retornados pela API.");
    Console.WriteLine($"Detalhes: {ex.Message}");
}

public class CatFactResponse
{
    [JsonPropertyName("fact")]
    public string? Fact { get; set; }

    [JsonPropertyName("length")]
    public int Length { get; set; }
}
