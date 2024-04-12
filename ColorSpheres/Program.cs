using System;

class Color
{
    int red;
    int green;
    int blue;
    int alpha;

    // Construtor que aceita red, green e blue, colocando alpha a 255 (opaco)
    Color(int red, int green, int blue)
    {
        // Define o alpha como 255 (opaco)
        alpha = 255;

        // Verifica se os valores de red, green e blue estão dentro dos parâmetros
        this.red = Clamp(red, 0, 255);
        this.green = Clamp(green, 0, 255);
        this.blue = Clamp(blue, 0, 255);
    }

    // Construtor que aceita todos os parâmetros necessários para inicializar o estado de uma cor
    Color(int red, int green, int blue, int alpha)
    {
        // Verifica se os valores estão dentro dos parâmetros
        this.red = Clamp(red, 0, 255);
        this.green = Clamp(green, 0, 255);
        this.blue = Clamp(blue, 0, 255);
        this.alpha = Clamp(alpha, 0, 255);
    }

    // Método para a cor Vermelha
    int GetRed()
    {
        return red;
    }

    // Método para a cor Verde
    int GetGreen()
    {
        return green;
    }

    // Método para a cor Azul
    int GetBlue()
    {
        return blue;
    }

    // Método para o Alpha
    int GetAlpha()
    {
        return alpha;
    }

    // Método para garantir que os valores estejam dentro dos limites permitidos
    int Clamp(int value, int min, int max)
    {
        if (value < min)
            return min;
        else if (value > max)
            return max;
        else
            return value;
    }

    static void Main(string[] args)
    {
        // Exemplo de uso da classe Color
        Color myColor = new Color(100, 200, 50);
        Console.WriteLine($"Red: {myColor.GetRed()}, Green: {myColor.GetGreen()}, Blue: {myColor.GetBlue()}, Alpha: {myColor.GetAlpha()}");

        Color myColorWithAlpha = new Color(100, 200, 50, 128);
        Console.WriteLine($"Red: {myColorWithAlpha.GetRed()}, Green: {myColorWithAlpha.GetGreen()}, Blue: {myColorWithAlpha.GetBlue()}, Alpha: {myColorWithAlpha.GetAlpha()}");
    }
}
