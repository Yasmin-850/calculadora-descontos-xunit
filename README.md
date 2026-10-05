# Calculadora de Descontos - xUnit

Projeto desenvolvido para a disciplina de Gestão e Qualidade de Software.

O objetivo é praticar testes unitários em .NET 10 utilizando xUnit, com foco na diferença entre `[Fact]` e `[Theory]`.

## Funcionalidades

A classe `DescontoService` possui os seguintes métodos:

### ObterCategoriaCliente

Define a categoria do cliente de acordo com a quantidade de compras:

- Menos de 5 compras: BRONZE
- Entre 5 e 10 compras: PRATA
- Mais de 10 compras: OURO

### CalcularDescontoPorPercentual

Calcula o valor final de uma compra após a aplicação de um desconto percentual.

Exemplo:

Valor original: R$ 100  
Desconto: 10%  
Valor final: R$ 90

### EValidoParaCupom

Verifica se o cliente pode utilizar um cupom.

O cupom é válido quando:

- O cliente possui 18 anos ou mais; ou
- É a primeira compra do cliente.

## Diferença entre [Fact] e [Theory]

### [Fact]

O `[Fact]` é utilizado quando queremos executar um teste único, sem receber diferentes conjuntos de parâmetros.

### [Theory]

O `[Theory]` permite executar o mesmo método de teste várias vezes utilizando diferentes dados.

Os dados podem ser fornecidos através de `[InlineData]`.

Exemplo:

```csharp
[Theory]
[InlineData(2, "BRONZE")]
[InlineData(7, "PRATA")]
[InlineData(15, "OURO")]