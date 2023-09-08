using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class InformacionEconomica
    {
        public string establecimientoInformacion { get; set; }
        public string fecha { get; set; }
        public string actividadEconomicaRTU { get; set; }
        public string detalleActividad { get; set; }
        public List<FuentesIngreso> fuentesIngresos { get; set; }
        public List<MontosIngreso> montosIngresos { get; set; }
        public List<MontosEgreso> montosEgresos { get; set; }
        public string propositoRC { get; set; }
    }

}