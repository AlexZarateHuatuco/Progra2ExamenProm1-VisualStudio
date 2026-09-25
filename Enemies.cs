using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2ExamenP1_VisualStudio
{
    internal class Enemies : Entities
    {
        private bool estaVivo;
        private bool yaImprimiMuerte;
        private int vecesQueRecibioDaño;
        public Enemies(int vidaMaxima, int daño) : base(vidaMaxima, daño)
        {
            this.estaVivo = true;
            this.yaImprimiMuerte = false;
            this.vecesQueRecibioDaño = 0;

            Console.WriteLine("Se creo un enemigo con " + vidaMaxima + " de vida y " + daño + " de daño");
        }
        public override void Atacar()
        {
            //jugador.VidaActual = jugador.VidaActual - this.daño;
            //Torre.VidaActual = Torre.VidaActual - this.daño;
        }
        public override void RecibirDaño(int cantidad)
        {
            this.vecesQueRecibioDaño = this.vecesQueRecibioDaño + 1;

            if (cantidad < 0)
            {
                Console.WriteLine("ERROR: no se puede recibir daño negativo");
                return;
            }

            int vidaAntes = this.VidaActual;
            this.VidaActual = this.VidaActual - cantidad;

            Console.WriteLine("El enemigo recibio " + cantidad + " de daño");
            Console.WriteLine("Vida antes: " + vidaAntes);
            Console.WriteLine("Vida ahora: " + this.VidaActual);
             
            if (this.VidaActual <= 0)
            {
                this.VidaActual = 0;
                this.estaVivo = false;

                if (this.yaImprimiMuerte == false)
                {
                    Console.WriteLine("*** El enemigo ha muerto ***");
                    this.yaImprimiMuerte = true;
                }
                else
                {
                    Console.WriteLine("El enemigo ya estaba muerto, no hace falta pegarle mas");
                }
            }
            else
            {
                Console.WriteLine("Al enemigo le quedan " + this.VidaActual + " puntos de vida");
            }

            Console.WriteLine("----------------------------------------");
        }

        public int GetDaño()
        {
            int dañoQueVoyARetornar = this.daño;
            return dañoQueVoyARetornar;
        }

        public bool EstaVivo()
        {
            if (this.VidaActual > 0)
            {
                return true;
            }
            else if (this.VidaActual == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public void MostrarEstado()
        {
            Console.WriteLine("===== ESTADO DEL ENEMIGO =====");
            Console.WriteLine("Vida: " + this.VidaActual);
            Console.WriteLine("Daño: " + this.daño);

            if (this.estaVivo == true)
            {
                Console.WriteLine("Estado: VIVO");
            }
            else
            {
                Console.WriteLine("Estado: MUERTO");
            }

            Console.WriteLine("Veces que recibio daño: " + this.vecesQueRecibioDaño);
            Console.WriteLine("=====================================");
        }
    }
}
