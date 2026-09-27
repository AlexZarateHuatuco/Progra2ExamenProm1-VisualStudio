using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2ExamenP1_VisualStudio
{
    internal class Tower : Entities
    {
        protected string nombreTorre;
        protected int nivel;

        public Tower(string nombre, int vida, int daño) : base(vida, daño)
        {
            this.nombreTorre = nombre;
            this.nivel = 1;
        }

        // Fibonacci: para el costo de mejora de las torres

        public int CalcularFibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }

        public void MejorarTorre()
        {
            int costo = CalcularFibonacci(nivel + 1) * 50;

            Console.WriteLine($"Mejorando torre: {nombreTorre.ToUpper()}");
            Console.WriteLine($"Nivel actual: {nivel}");
            Console.WriteLine($"Costo: {costo} oro (Escalado Fibonacci Nivel {nivel + 1})");

            nivel++;
            daño += 15;
            VidaActual += 50;

            Console.WriteLine($"{nombreTorre} subio al Nivel {nivel}! (Nuevo Daño: {daño}, Nueva Vida: {VidaMaxima})");
        }

        public virtual void Atacar(Entities enemigo)
        {
            if (VidaActual <= 0)
            {
                Console.WriteLine($"{nombreTorre} está destruida y no puede atacar a un enemigo causando {daño} de daño");
                return;
            }

            if (enemigo != null)
            {
                Console.WriteLine($"{nombreTorre} ataca a un enemigo causando {daño} de daño");
                enemigo.RecibirDaño(daño);
            }
        }

        public override void RecibirDaño(int cantidad)
        {
            if (cantidad <= 0)
            {
                return;
            }

            VidaActual -= cantidad;

            if (VidaActual <= 0)
            {
                VidaActual = 0;
                Console.WriteLine($"{nombreTorre} ha sido destruida");
            }
            else
            {
                Console.WriteLine($"{nombreTorre} recibió {cantidad} de daño. Vida restante: {VidaActual} || {VidaMaxima}");
            }
        }
    }
}
