using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class DatosPep
    {
        public string entidad { get; set; }
        public string puestoDesempenia { get; set; }
        public string paisEntidad { get; set; }
        public List<int> origenRiqueza { get; set; }
        public string otroOrigenRiqueza { get; set; }
    }

}