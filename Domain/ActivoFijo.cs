using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class ActivoFijo
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public decimal ValorReesidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaAdquicision { get; set; }
        public TipoActivo TipoActivo { get; set; }
        public MetodoDepreciacion metodoDepreciacion { get; set; }
    }
}
