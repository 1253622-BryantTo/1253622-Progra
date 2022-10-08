// Bryant Tó y Sebastian Echeverria

Console.WriteLine("El residual de 25 / 3 = ", Residuo(25, 3));
Console.WriteLine(Suma(25, 3));
Console.ReadKey();
int Suma(int Valor1, int Valor2)
{
    return Valor1 + Valor2;
}

int multiplicacion(int Valor1, int valor2)
{
    var Contador = 0;
    for (int i = 0; i < valor2; i++)
    {
       Contador = Suma(Contador, Valor1);
    }
    return Contador;
}

int Potencia(int Base, int Exponente)
{
    var Contador = 1;

    for (int i = 0; i < Exponente; i++)
    {
        Contador = multiplicacion(Contador, Base);
        
    }
    return Contador;
}

int Resta(int Valor1, int Valor2)
{

    return Valor1-Valor2;
}
int Residuo(int Divisor,int Dividendo)
{
    
    int Resultado = Resta(Divisor, Dividendo);
    while (Resultado >= 0)
    {
        Resultado = Resta(Resultado, Dividendo);
    }
    return Resultado;
}