/*
    Situação problema:
    Criação de uma classe para representar um botão no programa.
    O botão precisa de um texto, uma cor e uma ação no clique.
    O texto é uma string. A cor também é uma string, porém só pode aceitar
    três valores: azul, amarelo e vermelho.
*/

/*
class Button
{
    public string Text { get; private set; }
    public string Color { get; private set; }

    public Button(string text, string color)
    {
        this.Text = text;
        this.Color = color;
    }
}

*/

/*
    Há um problema nessa classe. Ela aceita qualquer valor que seja string na propriedade Color, porém,
    o Button só pode ter apenas três cores. Além disso, a pessoa desenvolvedora que pegar o código,
    poderá escrever de qualquer maneira essas palavras, o que pode dificultar um pouco dependendo da forma
    com que o resto do código foi feito.

    Para tentar solucionar isso, podemos criar uma classe Colors com constantes estáticas para não ter esse problema de digitação.
    Mas, ainda assim, isso não impediria de alguém definir qualquer valor na string. Além disso, não faz sentido criar uma classe
    apenas para informar aos devs as cores que serão permitidas em um botão.

    A solução que o C# disponibiliza para esses problemas é o Enum.
*/

enum ButtonColors
{
    Azul,
    Vermelho,
    Amarelo
}

/*
    Agora, a propriedade Color não será mais do tipo string, mas do tipo ButtonColors.
*/

class Button
{
    public string Text { get; private set; }
    public ButtonColors Color { get; private set; }

    public Button(string text, ButtonColors color)
    {
        this.Text = text;
        this.Color = color;
    }
}

/*
    enums são fortemente tipados. Em variáveis ou propriedades do tipo ButtonColors, só podemos usar valores definidos neste enum. Exemplos:
*/

// Button newButton = new Button("Ola", "Azul"); NÃO COMPILA
// Button newButton = new Button("Ola", ButtonColors.Amarelo); COMPILA