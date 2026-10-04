# Consumer Cat Fact API

Aplicação console em C#/.NET criada para consumir uma API de fatos aleatórios sobre gatos.

## Objetivo

Consumir o endpoint:

`https://catfact.ninja/fact`

A API retorna um JSON semelhante a:

```json
{
  "fact": "Many cats cannot properly digest cow's milk. Milk and milk products give them diarrhea.",
  "length": 87
}
```

O programa lê o campo `fact` e exibe o fato no console.

## Exemplo de execução

```text
Iniciando requisição para obter um fato sobre gatos:

https://catfact.ninja/fact

Fato sobre Gatos:
Many cats cannot properly digest cow's milk. Milk and milk products give them diarrhea.
```

Como a API retorna um fato aleatório, o texto pode ser diferente a cada execução.

## Tecnologias utilizadas

- C#
- .NET 8
- HttpClient
- System.Text.Json

## Como executar

Com o SDK do .NET instalado, execute:

```bash
dotnet run
```
