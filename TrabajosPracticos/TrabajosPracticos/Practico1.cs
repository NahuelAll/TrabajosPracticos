using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practicoResolucion
{
    public class Practico1
    {
        public void Ejercicio1()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Ingrese el numero a ser mostrado");
                Console.WriteLine($"El numero ingresado es: {numero} ");
            }
            catch (Exception)
            {
                Console.WriteLine("El ejercicio 1 no pudo ser completado");
            }
        }

        public void Ejercicio2()
        {
            try
            {
                int sumando1 = ConsoleUtils.ReadInteger("Ingrese el primer sumando");
                int sumando2 = ConsoleUtils.ReadInteger("Ingrese el segundo sumando");
                Console.WriteLine("La suma es: " + (sumando1 + sumando2).ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("El ejercicio 2 no se pudo completar");
            }
        }

        public void Ejercicio3()
        {
            try
            {
                int numeroP = ConsoleUtils.ReadInteger("Ingrese el numero principal");
                int numeroV = ConsoleUtils.ReadInteger("Ingrese el numero (suma, resta, multiplicacion)");
                Console.WriteLine("La suma es: " + (numeroP + numeroV).ToString());
                Console.WriteLine("La resta es: " + (numeroP - numeroV).ToString());
                Console.WriteLine("La multiplicacion es: " + (numeroP * numeroV).ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("El ejercicio 3 no se pudo completar");
            }
        }

        public void Ejercicio4()
        {
            try
            {
                int Base = ConsoleUtils.ReadInteger("Ingrese su base");
                int altura = ConsoleUtils.ReadInteger("ingrese su altura");
                Console.WriteLine("Su area es de = " + (Base * altura));
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 4 no se pudo completar");
            }
        }

        public void Ejercicio5()
        {
            try
            {
                int Base = ConsoleUtils.ReadInteger("Ingrese su base");
                int altura = ConsoleUtils.ReadInteger("ingrese su altura");
                Console.WriteLine("El perimetro de su rectangulo es de = " + 2 * (Base + altura));
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 5 no se pudo completar");
            }
        }

        public void Ejercicio6()
        {
            try
            {
                Console.WriteLine("Ingrese los grados Celsius para convertirlos en Fahrenheit");
                int celsius = ConsoleUtils.ReadInteger("Grados Celsius (°C)");
                Console.WriteLine("Su conversion es de = " + ((celsius * 9 / 5) + 32) + " Fahrenheit");
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 6 no se pudo completar");
            }
        }

        public void Ejercicio7()
        {
            try
            {
                int km = ConsoleUtils.ReadInteger("Ingrese cuantos km quiere convertir");
                Console.WriteLine("Su conversion de km a metros es de = " + (km * 1000) + "km");
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 7 no se pudo completar");
            }
        }

        public void Ejercicio8()
        {
            try
            {
                int num1 = ConsoleUtils.ReadInteger("Ingrese su numero");
                int num2 = ConsoleUtils.ReadInteger("Ingrese su numero 2");
                int num3 = ConsoleUtils.ReadInteger("Ingrese su numero 3");
                Console.WriteLine("Promedio de = " + ((num1 + num2 + num3) / 3));
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 8 no se pudo completar");
            }
        }

        public void Ejercicio9()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Ingrese su numero");
                Console.WriteLine("El doble es = " + Math.Pow(numero, 2));
                Console.WriteLine("El doble es = " + Math.Pow(numero, 3));
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 9 no se pudo completar");
            }
        }
        public void Ejercicio10()
        {
            try
            {
                int precio = ConsoleUtils.ReadInteger("Ingrese su valor base");
                int iva = ConsoleUtils.ReadInteger("Cuanto Iva se le va a agregar?");
                int montoIva = precio * iva / 100;
                int precioFinal = precio + montoIva;
                Console.WriteLine("Tu precio inicial es de " + precio + " se le suma un " + iva + "% de Iva, quedando un total de " + precioFinal);
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 10 no se pudo completar");
            }
        }

        public void Ejercicio11_12()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Ingrese su numero");
                if (numero >= 0)
                {
                    Console.WriteLine(numero + " Es positivo");
                }
                else
                {
                    Console.WriteLine(numero + " Es negativo");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 11 y 12 no se pudo completar");
            }
        }

        public void Ejercicio13()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Ingrese su numero ");
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " Es par");
                }
                else
                {
                    Console.WriteLine(numero + " Es impar");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 13 no se pudo completar");
            }
        }

        public void Ejercicio14()
        {
            try
            {
                int edad = ConsoleUtils.ReadInteger("Ingrese su numero ");
                if (edad >= 18)
                {
                    Console.WriteLine("Es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Es menor de edad");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 14 no se pudo completar");
            }
        }

        public void Ejercicio15()
        {
            try
            {
                int numero1 = ConsoleUtils.ReadInteger("Ingrese un numero");
                int numero2 = ConsoleUtils.ReadInteger("Ingrese un numero");
                if (numero1 > numero2)
                {
                    Console.WriteLine(numero1 + " es mayor que " + numero2);
                }
                else
                {
                    Console.WriteLine(numero2 + " es mayor que " + numero1);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 15 no se pudo completar");
            }
        }

        public void Ejercicio16()
        {
            try
            {
                int numero1 = ConsoleUtils.ReadInteger("Ingrese un numero");
                if (numero1 % 5 == 0)
                {
                    Console.WriteLine(numero1 + " es multiplo de 5");
                }
                else
                {
                    Console.WriteLine(numero1 + " no es multiplo de 5");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 16 no se pudo completar");
            }
        }

        public void Ejercicio17()
        {
            try
            {
                int numero1 = ConsoleUtils.ReadInteger("Ingrese un numero");
                if (numero1 > 100)
                {
                    Console.WriteLine(numero1 + " es mayor que 100");
                }
                else
                {
                    Console.WriteLine(numero1 + " es menor que 100");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 17 no se pudo completar");
            }
        }

        public void Ejercicio18()
        {
            try
            {
                int notaPase = 6;
                int numero1 = ConsoleUtils.ReadInteger("Ingrese la nota");
                if (numero1 >= notaPase)
                {
                    Console.WriteLine("Aprobado");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 18 no se pudo completar");
            }
        }

        public void Ejercicio19()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Ingrese un numero");
                if (numero >= 10 && numero <= 20)
                {
                    Console.WriteLine(numero + " esta entre 10 y 20");
                }
                else
                {
                    Console.WriteLine("El numero no se encuentra entre 10 y 20");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 19 no se pudo completar");
            }
        }

        public void Ejercicio20()
        {
            try
            {
                Console.WriteLine("Ingrese una letra");
                string letra = Console.ReadLine();
                string letraMin = letra.ToLower();
                if (letraMin == "a" ||
                    letraMin == "e" ||
                    letraMin == "i" ||
                    letraMin == "o" ||
                    letraMin == "u")
                {
                    Console.WriteLine(letraMin + " es vocal");
                }
                else
                {
                    Console.WriteLine(letraMin + " no es vocal");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 20 no se pudo completar");
            }
        }

        public void Ejercicio21()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Ingrese un numero");
                if (numero >= 0)
                {
                    Console.WriteLine(numero + " es positivo");
                }
                else
                {
                    Console.WriteLine(numero + " es negativo");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 21 no se pudo completar");
            }
        }

        public void Ejercicio22()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Ingrese un numero");
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " es par");
                }
                else
                {
                    Console.WriteLine(numero + " es impar");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 22 no se pudo completar");
            }
        }

        public void Ejercicio23()
        {
            try
            {
                int edad = ConsoleUtils.ReadInteger("Ingrese su numero ");
                if (edad >= 18)
                {
                    Console.WriteLine("Es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Es menor de edad");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 23 no se pudo completar");
            }
        }

        public void Ejercicio24()
        {
            try
            {
                int numero1 = ConsoleUtils.ReadInteger("Ingrese un numero");
                int numero2 = ConsoleUtils.ReadInteger("Ingrese un numero");
                if (numero1 > numero2)
                {
                    Console.WriteLine(numero1 + " es mayor que " + numero2);
                }
                else
                {
                    Console.WriteLine(numero2 + " es mayor que " + numero1);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 24 no se pudo completar");
            }
        }

        public void Ejercicio25()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre del producto");
                string producto = Console.ReadLine();
                int precio = ConsoleUtils.ReadInteger("Ingrese su precio");
                if (precio > 1000)
                {
                    Console.WriteLine(producto + " tiene descuento");
                }
                else
                {
                    Console.WriteLine(producto + " no tiene descuento");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 25 no se pudo completar");
            }
        }

        public void Ejercicio26()
        {
            try
            {
                int temperatura = ConsoleUtils.ReadInteger("Ingrese la temperatura");
                if (temperatura > 25)
                {
                    Console.WriteLine("hace calor");
                }
                else if (temperatura >= 10 && temperatura <= 25)
                {
                    Console.WriteLine("esta templado");
                }
                else if (temperatura < 10)
                {
                    Console.WriteLine("hace frio");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 25 no se pudo completar");
            }
        }

        public void Ejercicio27()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Ingrese un numero");
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero + " es divisible por 3");
                }
                else
                {
                    Console.WriteLine(numero + " no es divisible por 3");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 27 no se pudo completar");
            }
        }

        public void Ejercicio28()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Ingrese un numero");
                int numero2 = ConsoleUtils.ReadInteger("Ingrese otro numero");
                if (numero == numero2)
                {
                    Console.WriteLine(numero + " es igual a " + numero2);
                }
                else
                {
                    Console.WriteLine(numero + " es distinto a " + numero2);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 28 no se pudo completar");
            }
        }

        public void Ejercicio29()
        {
            try
            {
                int ano = ConsoleUtils.ReadInteger("Ingrese el año");
                int dia = ConsoleUtils.ReadInteger("Cuantos dias tiene?");
                if (dia == 365)
                {
                    Console.WriteLine(ano + " es bisiesto");
                }
                else
                {
                    Console.WriteLine(ano + " no es bisiesto");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 29 no se pudo completar");
            }
        }

        public void Ejercicio30()
        {
            try
            {
                Console.WriteLine("Ingrese su contrasena");
                string clave = Console.ReadLine();
                if (clave.Length >= 8)
                {
                    Console.WriteLine("Contrasena valida");
                }
                else
                {
                    Console.WriteLine("Contrasena invalida");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 30 no se pudo completar");
            }
        }

        public void Ejercicio31()
        {
            try
            {
                int num = 0;
                while (num < 10)
                {
                    num++;
                    Console.WriteLine(num);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 31 no se pudo completar");
            }
        }

        public void Ejercicio32()
        {
            try
            {
                int num = 0;
                while (num < 100)
                {
                    num++;
                    Console.WriteLine(num);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 32 no se pudo completar");
            }
        }

        public void Ejercicio33()
        {
            try
            {
                int num = 0;
                while (num < 50)
                {
                    num++;
                    if (num % 2 == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 33 no se pudo completar");
            }
        }

        public void Ejercicio34()
        {
            try
            {
                int num = 0;
                while (num < 50)
                {
                    num++;
                    if (num % 2 != 0)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 34 no se pudo completar");
            }
        }

        public void Ejercicio35()
        {
            try
            {
                int num = 0;
                int suma = 0;
                while (num < 10)
                {
                    num++;
                    suma += num;

                    Console.WriteLine(suma);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 35 no se pudo completar");
            }
        }

        public void Ejercicio36()
        {
            try
            {
                int num = 0;
                int suma = 0;
                while (num < 100)
                {
                    num++;
                    suma += num;

                    Console.WriteLine(suma);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 36 no se pudo completar");
            }
        }

        public void Ejercicio37()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Que tabla quiere ver");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 37 no se pudo completar");
            }
        }

        public void Ejercicio38()
        {
            try
            {
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 38 no se pudo completar");
            }
        }

        public void Ejercicio39()
        {
            try
            {
                int num = ConsoleUtils.ReadInteger("De que numero quiere sacar su factorial");
                int resultado = 1;
                for (int i = 1; i <= num; i++)
                {
                    if (num == 0)
                    {
                        Console.WriteLine(1);
                    }
                    else
                    {
                        resultado *= i;
                    }
                }
                Console.WriteLine($"{resultado}");
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 39 no se pudo completar");
            }
        }

        public void Ejercicio40()
        {
            try
            {
                int num = ConsoleUtils.ReadInteger("Que numero quieres elevar");
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(Math.Pow(num, i));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 40 no se pudo completar");
            }
        }

        public void Ejercicio41()
        {
            try
            {
                int num = ConsoleUtils.ReadInteger("Ingrese un numero (0 para terminar)");
                while (num != 0)
                {
                    num = ConsoleUtils.ReadInteger("Ingrese un numero (0 para terminar)");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 41 no se pudo completar");
            }
        }

        public void Ejercicio42()
        {
            try
            {
                int num = ConsoleUtils.ReadInteger("Cuantos numeros va a contar");
                int cantidadP = 0;
                for (int i = 0; i < num; i++)
                {
                    int lectorNum = ConsoleUtils.ReadInteger("Ingrese un numero");
                    if (lectorNum >= 0)
                    {
                        cantidadP++;
                    }
                }
                Console.WriteLine($"la cantidad de numeros positivos es de {cantidadP}");

            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 42 no se pudo completar");
            }
        }

        public void Ejercicio43()
        {
            try
            {
                int cantidad = ConsoleUtils.ReadInteger("Cantidad de numeros a calcular");
                int suma = 0;
                for (int i = 0; i < cantidad; i++)
                {
                    int num = ConsoleUtils.ReadInteger("Ingrese un numero");
                    suma += num;
                }
                Console.WriteLine($"El promedio es de {suma / cantidad}");
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 43 no se pudo completar");
            }
        }

        public void Ejercicio44()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 44 no se pudo completar");
            }
        }

        public void Ejercicio45()
        {
            try
            {
                int a = 0;
                int b = 1;
                int c;
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(a);
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 45 no se pudo completar");
            }
        }

        public void Ejercicio46()
        {
            try
            {
                for (int i = 1; i < 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 46 no se pudo completar");
            }
        }

        public void Ejercicio47()
        {
            try
            {
                int numero = ConsoleUtils.ReadInteger("Cuantos numeros va a revisar");
                int numMayor = 0;
                for (int i = 0; i < numero; i++)
                {
                    int escrito = ConsoleUtils.ReadInteger("Ingrese un numero");
                    if (escrito > 10)
                    {
                        Console.WriteLine(escrito + " es mayor a 10");
                        numMayor++;
                    }
                }
                Console.WriteLine("hay un total de " + numMayor + " numeros mayores a 10");
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 47 no se pudo completar");
            }
        }

        public void Ejercicio48()
        {
            try
            {
                int cantidad = ConsoleUtils.ReadInteger("Cuantos numeros va a contar");
                int suma = 0;
                for (int i = 0; i < cantidad; i++)
                {
                    int escrito = ConsoleUtils.ReadInteger("Ingrese un numero");
                    if (escrito % 2 == 0)
                    {
                        suma += escrito;
                    }
                    else
                    {
                        Console.WriteLine("no es par");
                    }
                }
                Console.WriteLine("total de " + suma);
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 48 no se pudo completar");
            }
        }

        public void Ejercicio49()
        {
            try
            {
                int cantidad = ConsoleUtils.ReadInteger("Cuantos numeros va a contar");
                int negContador = 0;

                for (int i = 0; i < cantidad; i++)
                {
                    int escrito = ConsoleUtils.ReadInteger("Ingrese un numero");
                    if (escrito < 0)
                    {
                        negContador++;
                    }
                }
                Console.WriteLine(negContador + " negativos ingresados");
            }
            catch (Exception)
            {
                Console.WriteLine("el ejercicio 49 no se pudo completar");
            }
        }
    }
}
