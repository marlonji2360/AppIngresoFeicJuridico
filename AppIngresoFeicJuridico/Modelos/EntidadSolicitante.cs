using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class EntidadSolicitante
    {
        public Lugar lugar { get; set; }
        public string fecha { get; set; }
        public string altoRiesgo { get; set; }
        public DatosIdentificacion datosIdentificacion { get; set; }
        public string participacionAccionaria { get; set; }
        public List<EstructuraAccionarium> estructuraAccionaria { get; set; }
        public List<OrganoAdmon> organoAdmon { get; set; }
        public string cpe { get; set; }
        public RepresentanteLegal representanteLegal { get; set; }
        public List<InformacionEconomica> informacionEconomica { get; set; }
    }

}