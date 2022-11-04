using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1BT_1253622
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool sesion = true;
            while (sesion == true)
            {
                Console.WriteLine("Ingrese que ejercicio desea ver:");
                Console.WriteLine();
                Console.WriteLine("1. Ejercicio 21 y 22");
                Console.WriteLine("2. Ejercicio 24");
                Console.WriteLine("3. Ejercicio 25");
                Console.WriteLine("4. Ejercicio 35");
                Console.WriteLine("5. Ejercicio 11");
                Console.WriteLine("6. Ejercicio 13");
                Console.WriteLine("0. Salir");
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                int Opccion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (Opccion)
                {
                    case 1:
                        Ejercicio21y22();
                        break;
                    case 2:
                        Ejercicio24();
                        break;
                    case 3:
                        Ejercicio25();
                        break;
                    case 4:
                        Ejercicio35();
                        break;
                    case 5:
                        Ejercicio11();
                        break;
                    case 6:
                        Console.WriteLine("Ingrese que ciclo desea ver");
                        Console.WriteLine("1. Ciclo While");
                        Console.WriteLine("2. Ciclo do While");
                        Console.WriteLine("3. Ciclo for");
                        int Opccio_Ciclos = int.Parse(Console.ReadLine());
                        switch (Opccio_Ciclos)
                        {
                            case 1:
                                While();
                                break;
                            case 2:
                                dowhile();
                                break;
                            case 3:
                                For();
                                break;
                        }

                        break;
                    case 0:
                        sesion = false;
                        break;
                }
            }
            
            void Ejercicio21y22()
            {
                double X = 0;
                Console.WriteLine("Ingrese un Valor a X");
                X = double.Parse(Console.ReadLine());

                double Y1 = (3 * Math.Pow(X, 3)) - (Math.Pow(X, 1 / 3)) + (4 * Math.Pow(X, 2));
                double Y2 = (4 * Math.Pow(X, 3)) - (3 * Math.Pow(X, 2)) + (2 * X) - 5;
                double Y3 = (5 * Math.Pow(X, 1 / 3)) + (4 * Math.Pow(X, 2)) + 6;

                Console.WriteLine("El resultado de la primera ecuacion es: {0}", Y1);
                Console.WriteLine("El resultado de la primera ecuacion es: {0}", Y2);
                Console.WriteLine("El resultado de la primera ecuacion es: {0}", Y3);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                
            }
            void Ejercicio24()
            {
                double Recursos_Humanos = 50;
                double Manufactura = 25;
                double Empaquetado = 15;
                double Publicidad = 10;

                Console.WriteLine("Ingrese el presupues de la empresa en Q:");
                double Presupues_Emprese = double.Parse(Console.ReadLine());

                Recursos_Humanos = (Recursos_Humanos * Presupues_Emprese) / 100;
                Manufactura = (Manufactura * Presupues_Emprese) / 100;
                Empaquetado = (Empaquetado * Presupues_Emprese) / 100;
                Publicidad = (Publicidad * Presupues_Emprese) / 100;

                Console.WriteLine("El porcentaje de dinero que le corresponde a Recursos Humanos es de: Q" + Recursos_Humanos);
                Console.WriteLine("El porcentaje de dinero que le corresponde a Manufactura es de: Q" + Manufactura);
                Console.WriteLine("El porcentaje de dinero que le corresponde a Empaquetado es de: Q" + Empaquetado);
                Console.WriteLine("El porcentaje de dinero que le corresponde a Publicidad es de: Q" + Publicidad);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            void Ejercicio25()
            {
                double Salario;
                Console.WriteLine("Ingrese el salario del trabajador");
                Salario = double.Parse(Console.ReadLine());
                var ISSS = Salario * 0.09;
                var AFP = Salario * 0.07;
                var Renta = Salario * 0.1;
                var Total = ISSS + AFP + Renta;

                Salario = Salario - Total;
                Console.WriteLine("El Salario Neto a pagar del Empleado es de: Q" + Salario);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.Clear();
            }
            void Ejercicio35()
            {
                Console.WriteLine("Ingrese un numero");
                double N1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese un segundo numero");
                double N2 = double.Parse(Console.ReadLine());

                var Suma = N1 + N2;
                var Resta = N1 - N2;
                var Multiplicacion = N1 * N2;
                var Division = N1 / N2;
                var Mod = N1 % N2;

                Console.WriteLine("El resultado de la suma: " + Suma);
                Console.WriteLine("El resultado de la Resta: " + Resta);
                Console.WriteLine("El resultado de la Multiplicacion: " + Multiplicacion);
                Console.WriteLine("El resultado de la Division: " + Division);
                Console.WriteLine("El resultado de Mod %: " + Mod);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }
            void Ejercicio11()
            {
                string Articulo = "";
                int Cantidad_Articulos;
                double Precio_Articulo;
                double Descuento = 0.15;

                Console.WriteLine("Ingrese el nombre del articulo");
                Articulo = Console.ReadLine();
                Console.WriteLine("Ingrese cantidad de articulos");
                Cantidad_Articulos = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio del articulo");
                Precio_Articulo = double.Parse(Console.ReadLine());

                var Precio_Total = Cantidad_Articulos * Precio_Articulo;
                var Precio_Iva = Precio_Total * 0.13;
                var Precio_Total_IVA = Precio_Total + Precio_Iva;

                if (Precio_Total_IVA > 1000)
                {
                    var Precio_Total_Descuento = Precio_Total_IVA * Descuento;
                    var Precio_Total_ = Precio_Total_IVA - Precio_Total_Descuento;
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("Ingrese NIT: ");
                    var NIT = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Factura");
                    Console.WriteLine("NIT: " + NIT);
                    Console.WriteLine("Cantidad: " + Cantidad_Articulos);
                    Console.WriteLine("Descripccion:" + Articulo);
                    Console.WriteLine("Total: Q" + Precio_Total_);

                }
                else
                {
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                    Console.Write("Ingrese NIT: ");
                    var NIT = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Factura");
                    Console.WriteLine("NIT: " + NIT);
                    Console.WriteLine("Cantidad: " + Cantidad_Articulos);
                    Console.WriteLine("Descripccion:" + Articulo);
                    Console.WriteLine("Total: Q" + Precio_Total_IVA);
                }
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            }

                void While()
                {
                    int suma = 0;
                    int contador = 1;
                    while (contador <= 100)
                    {
                        suma = suma + contador;
                        contador += 1;
                        Console.WriteLine("La suma de los 100 primeros numeros naturales: " + suma);
                    }
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
                void dowhile()
                {
                    int suma_2 = 0;
                    int contador_2 = 1;
                    do
                    {
                        suma_2 = suma_2 + contador_2;
                        contador_2 += 1;
                        Console.WriteLine("La suma de los 100 primeros numeros naturales: " + suma_2);
                    } while (contador_2 <= 100);
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
                void For()
                {
                    int suma_3 = 0;
                    for (int i = 1; i <= 100; i++)
                    {
                        suma_3 = suma_3 + i;
                        Console.WriteLine("La suma de los 100 primeros numeros naturales: " + suma_3);
                    }
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                }
            
            Console.ReadKey();
        }
    }
}
