using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Infraestructura
{
    public class ActivoModel
    {
        ActivoFijo[] activo;
        public void Add(ActivoFijo a)
        {
            if (activo == null)
            {
                activo = new ActivoFijo[1];
                activo[0] = a;

            }
            else
            {
                ActivoFijo[] tmp = new ActivoFijo[activo.Length + 1];
                Array.Copy(activo, tmp, activo.Length);
                tmp[tmp.Length - 1] = a;
                activo = tmp;
            }

        }
        public string mostrar()
        {
            string mostrar = "";
            
            if (activo != null)
            {
                foreach (ActivoFijo a in activo)
                {
                    
                    mostrar = $@"ID {a.ID}{Environment.NewLine} Codigo {a.Codigo}{Environment.NewLine} Nombre {a.Nombre}{Environment.NewLine} descripcion {a.Descripcion}{Environment.NewLine} valor del activo {a.ValorActivo}{Environment.NewLine}
valor residual {a.ValorReesidual}{Environment.NewLine} vida util {a.VidaUtil}{Environment.NewLine} Fecha de aquisicion {a.FechaAdquicision}{Environment.NewLine} TipoActivo {a.TipoActivo}{Environment.NewLine} Meto de depresiacion {a.metodoDepreciacion}{Environment.NewLine}{Environment.NewLine}" + mostrar;
                }
            }
            return mostrar;
        }
    }
}
