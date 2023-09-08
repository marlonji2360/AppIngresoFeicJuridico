using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class SociedadMercantil
    {
        public List<EscrituraSolicitante> escrituraSolicitante { get; set; }
        public PatenteSociedad patenteSociedad { get; set; }
    }

}