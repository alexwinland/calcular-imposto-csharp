# Calculador de Impostos em C# 🧮💰

Olá, pessoal! 👋 Se você sempre quis saber quanto realmente vai levar pra casa depois dos impostos e benefícios, este código em C# vai te ajudar! Ele faz todo o trabalho pesado para você. Vamos conferir como funciona essa belezura?

## O Que Este Código Faz?

Este código C# é como um assistente pessoal digital que calcula o quanto você vai receber após o imposto e adicionar seus benefícios. 🚀

### O Que Acontece Passo a Passo:

1. **Solicitação de Dados**:
   - Primeiro, ele pergunta o seu **salário**. Sim, aquele valor suado do seu trabalho duro!
   - Depois, pergunta pelos **benefícios** que você tem. Pode ser qualquer coisa boa, como um vale-alimentação ou bônus!

2. **Cálculo do Imposto**:
   - O código calcula o imposto baseado em faixas de salário:
     - **0 a 1100**: O imposto é 5% do salário.
     - **1101 a 2500**: O imposto é 10% do salário.
     - **Acima de 2500**: O imposto é 15% do salário.
   - É como um jogo de níveis, mas com dinheiro e menos diversão. 😅

3. **Resultado Final**:
   - O programa então calcula o valor final que você vai receber após o desconto do imposto e a adição dos benefícios.
   - Finalmente, ele exibe esse valor formatado com duas casas decimais. Porque, você sabe, a precisão é importante quando se trata de grana!

## Como Usar

1. **Compilação**:
   - Abra o terminal e compile o código usando o comando `csc CalcularImposto.cs`.
   - Isso criará um arquivo executável chamado `CalcularImposto.exe`.

2. **Execução**:
   - Execute o programa com o comando `CalcularImposto.exe`.
   - Siga as instruções e insira seu salário e benefícios quando solicitado.

3. **Visualização do Resultado**:
   - Após a execução, o programa mostrará o valor final que você receberá. É como um abraço virtual do seu contador! 🤗

## Exemplo de Execução

```shell
Digite o valor do salário: 2000
Digite o valor dos benefícios: 300
O valor final após impostos e benefícios é: 1900.00
