using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2ExamenP1_VisualStudio
{
    internal class Entities
    {
        private static readonly Random rnd = new Random();
        public int VidaMaxima { get; }
        protected readonly int daño;
        public int Daño => daño;
        public int VidaActual { get; protected set; }

        public Entities()
        {
            VidaMaxima = ObtenerValorFibonacciAleatorio();
            VidaActual = VidaMaxima;
            daño = ObtenerValorFibonacciAleatorio();
        }
        public virtual void Atacar()
        {
            // ...
        }
        public virtual int ObtenerDaño()
        {
            return daño;
        }

        public virtual void RecibirDaño(int daño)
        {
            // ...
        }
        private int ObtenerValorFibonacciAleatorio()
        {
            int numTerminos = 12;
            List<int> fibonacci = GenerarFibonacci(numTerminos);
            Random rnd = new Random();
            int valRandom = rnd.Next(2, numTerminos); // Rango entre índice 2 y 11
            return fibonacci[valRandom];
        }
        private List<int> GenerarFibonacci(int n)
        {
            List<int> fibonacci = new List<int>();
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                fibonacci.Add(a);
                int temp = a;
                a = b;
                b = temp + b;
            }
            return fibonacci;
        }
    }
}
