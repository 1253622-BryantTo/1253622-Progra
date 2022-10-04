// Bryant Tó y Sebastian Echeverria
int suma, multipicacion, potencia, N1, N2;

Console.WriteLine("Ingrese dos numero");
N1 = int.Parse(Console.ReadLine());
N2 = int.Parse(Console.ReadLine());

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
