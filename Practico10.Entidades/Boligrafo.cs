using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practico10.Entidades
{
    public class Boligrafo : IAcciones
    {
        //En Boligrafo:
        //i.El método Escribir reducirá la tinta en 0.3 por cada carácter
        //escrito.
        //ii.El método Recargar incrementará la tinta en tantas unidades
        //como se agreguen.
        //iii.La propiedad UnidadesDeEscritura retornará el valor del
        //atributo tinta.

        private ConsoleColor colorTinta;

        private float tinta;

        private float tintaInicio;
        public ConsoleColor Color 
        { 
            get => colorTinta; 
            set => throw new NotImplementedException(); 
        }
        
        public float UnidadesDeEscritura 
        { 
            get => tinta; 
            set => value = tinta; 
        }
        public Boligrafo(float unidades, ConsoleColor color)
        {
            colorTinta = color;
            tinta = unidades;
            tintaInicio = unidades;
        }
        public EscrituraWrapper Escribir(string texto)
        {
            float cantidadCaracteres = texto.Length;
            tinta = tinta - (cantidadCaracteres * 0.3f);
            return new EscrituraWrapper(ConsoleColor.Gray, texto);
        }

        public bool Recargar(int unidades)
        {
            if (tintaInicio == unidades)
            {
                return false;
            }
            //else if (unidades >= (tintaInicio - tinta))
            //{
            //    return false;
            //}
            else if (unidades < 0)
            {
                return false;
            }
            else
            {
                tinta = unidades;
                return true;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Clase: {this.GetType().Name}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Nivel de tinta: {tinta}");
            return sb.ToString();
        }
    }
}
