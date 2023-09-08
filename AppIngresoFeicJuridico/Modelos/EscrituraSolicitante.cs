using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class EscrituraSolicitante
    {
        public string establecimientoInformacion { get; set; }
        public string numero { get; set; }
        public string fecha { get; set; }
        public string notario { get; set; }
        public List<int> tipoModificacion { get; set; }
    }

}