Console.WriteLine("Ingrese una oracion");
string Oracion = Console.ReadLine();
Console.WriteLine();
char Delimitador = ' ';
string[] Palabra = Oracion.Split(Delimitador);
string[] Finales = new string[Oracion.Length];
int[] Frecuencia = new int[Oracion.Length];

for (int i = 0; i <Finales.Length; i++)
{
	Finales[i] = "";
	Frecuencia[i] = 0;
}
for (int i = 0; i < Oracion.Length; i++)
{
	for (int j = 0; j < Finales.Length; j++)
	{
		if (Finales[j] == "")
		{
			Finales[j] = Palabra[i];
			Frecuencia[j]++;
			break;

        }
        else if (Palabra[i] == Finales[j])
		{
			Frecuencia[j]++;
			break;
		}
	}
}

for (int i = 0; i < Finales.Length; i++)
{
	Console.WriteLine("Palabras " + Finales[i] + " Frecuenci " + Frecuencia[i]);
}
