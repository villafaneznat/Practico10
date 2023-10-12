using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico10.Entidades.Datos
{
    public class CartucheraMultiuso
    {
        List<IAcciones> lista;

        public CartucheraMultiuso() 
        {
            lista = new List<IAcciones>();
        }

        public void AgregarElementos(IAcciones elementos)
        {
            lista.Add(elementos);
        }

        public bool RecorrerElementos()
        {
            bool itemsRecargados = true;
            foreach (var item in lista)
            {
                switch (item.GetType().Name)
                {
                    case "Boligrafo":

                        if (item.UnidadesDeEscritura <= 0)
                        {
                            item.Recargar(20);
                            itemsRecargados = false;
                        }
                        else
                        {
                            item.UnidadesDeEscritura -= 1;
                        }
                        break;
                    case "Lapiz":
                        if (((IAcciones)item).UnidadesDeEscritura <= 0)
                        {
                            ((IAcciones)item).Recargar(20);
                            itemsRecargados = false;
                        }
                        else
                        {
                            ((IAcciones)item).UnidadesDeEscritura -= 1;
                        }
                        break;

                }

            }
            return itemsRecargados;
        }
    }
}
