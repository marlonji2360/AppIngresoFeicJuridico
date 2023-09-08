using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class InfoEconomicaEmpresa
    {
        public string establecimientoInformacion { get; set; }
        public string fecha { get; set; }
        public List<DatosIngresosEgreso> datosIngresosEgresos { get; set; }
    }

}