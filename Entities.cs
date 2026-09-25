using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2ExamenP1_VisualStudio
{
    internal class Entities
    {
        private int vidaMaxima;
        private int vidaActual;
        public int VidaMaxima { get; private set; }
        public int VidaActual { get; set; }
        protected int daño;

        public Entities(int vidaMaxima, int daño)
        {
            this.vidaMaxima = ObtenerValorFibonacciAleatorio();
            this.vidaActual = this.vidaMaxima;
            this.daño = ObtenerValorFibonacciAleatorio();
            
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
