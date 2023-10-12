using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico10.Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(float unidades)
        {
            tamanioMina = unidades;
        }
        ConsoleColor IAcciones.Color 
        { 
            get => ConsoleColor.Gray;
            set => throw new NotImplementedException(); 
        }
        float IAcciones.UnidadesDeEscritura 
        { 
            get => tamanioMina; 
            set => value = tamanioMina; 
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            float cantidadCaracteres = texto.Length;
            tamanioMina = tamanioMina - (cantidadCaracteres * 0.1f);

            return new EscrituraWrapper(ConsoleColor.Gray, texto);
        }

        bool IAcciones.Recargar(int unidades)
        {
            if (unidades >= tamanioMina)
            {
                throw new Exception("Las unidades no pueden ser superiores al valor de inicio dela tinta");
            }
            else
            {
                tamanioMina = (tamanioMina+ unidades);
                return true;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Clase: {this.GetType().Name}");
            sb.AppendLine($"Color: {((IAcciones)this).Color}");
            sb.AppendLine($"Tamaño de la mina: {tamanioMina}");
            return sb.ToString();
        }
    }
}
