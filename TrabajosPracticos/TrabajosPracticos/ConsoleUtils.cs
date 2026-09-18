using System;
using System.Collections.Generic;
using System.Text;

namespace practicoResolucion
{
    public class ConsoleUtils
    {
        public static int ReadInteger(string message)
        {
            Console.WriteLine(message);
            string valorUno = Console.ReadLine();
            if (!Int32.TryParse(valorUno, out int sumando1))
                throw new Exception("El valor ingresado es un numero invalido:");

            return sumando1;
        }
    }
}
