using System;

class Color
{
    int red;
    int green;
    int blue;
    int alpha;

    // Construtor que aceita todos os parâmetros necessários para inicializar o estado de uma cor
    public Color(int red, int green, int blue, int alpha)
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
}
