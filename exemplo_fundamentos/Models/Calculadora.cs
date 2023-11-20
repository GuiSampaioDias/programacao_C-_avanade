using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_fundamentos.Models
{
    public class Calculadora
    {
            public void Somar(int x, int y)
            {
                Console.WriteLine($"{x} + {y} = {x + y}");
            }
            
            public void Subtrair(int x, int y)
            {
                Console.WriteLine($"{x} - {y} = {x - y}");
            }
            
            public void Multiplicar(int x, int y)
            {
                Console.WriteLine($"{x} x {y} = {x * y}");
            }

            public void Dividir (int x, int y)
            {
                if (y == 0)
                    Console.WriteLine("Não é possivel a divisão por zero");
                else
                    Console.WriteLine($"{x} / {y} = {x / y}");
            }

            public void Potencia(int x, int y)
            {
                double pot = Math.Pow(x, y);
                Console.WriteLine($"{x} ^ {y} = {pot}");
            }

            public void Seno(double angulo)
            {   // Na biblioteca Math o seno é calculado com radiano
                double radiano = angulo * Math.PI / 180; // essa é a formula de calcular o radiano
                double seno = Math.Sin(radiano);
                Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
            }
            public void Coseno(double angulo)
            {   // Na biblioteca Math o coseno é calculado com radiano
                double radiano = angulo * Math.PI / 180; // essa é a formula de calcular o radiano
                double coseno = Math.Cos(radiano);
                Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
            }
            public void Tangente(double angulo)
            {   // Na biblioteca Math o seno é calculado com radiano
                double radiano = angulo * Math.PI / 180; // essa é a formula de calcular o radiano
                double tan = Math.Tan(radiano);
                Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tan, 4)}");
            }

            public void RaizQuadrada(double x)
            {
                double raiz =Math.Sqrt(x);
                Console.WriteLine($"Raiz quadrada de {x} = {Math.Round(raiz, 2)}");
            }
    }
}