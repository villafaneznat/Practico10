using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico10.Entidades.Datos
{
    public class CartucheraSimple
    {
        List<Boligrafo> boligrafoList;
        List<Lapiz> lapizList;

        public CartucheraSimple()
        {
            boligrafoList = new List<Boligrafo>();
            lapizList = new List<Lapiz>();
        }

        public void AgregarBoligrafos(Boligrafo bol)
        {
            boligrafoList.Add(bol);
        }
        public void AgregarLapices(Lapiz lap)
        {
            lapizList.Add(lap);
        }

        public bool RecorrerElementos()
        {
            return (itemsRecargadosBoligrafos() && itemsRecargadosLapices());
        }

        private bool itemsRecargadosLapices()
        {
            bool itemsRecargados = true;
            foreach (var lapiz in lapizList)
            {
                if (((IAcciones)lapiz).UnidadesDeEscritura == 0)
                {
                    ((IAcciones)lapiz).Recargar(20);
                    itemsRecargados = false;
                }
                else
                {
                    ((IAcciones)lapiz).UnidadesDeEscritura -= 1;
                }
            }
            return itemsRecargados;
        }

        private bool itemsRecargadosBoligrafos()
        {
            bool itemsRecargados = true;
            foreach (var item in boligrafoList)
            {
                if (item.UnidadesDeEscritura == 0)
                {
                    item.Recargar(20);
                    itemsRecargados = false;
                }
                else
                {
                    item.UnidadesDeEscritura -= 1;
                }
            }
            return itemsRecargados;
        }
    }
}
