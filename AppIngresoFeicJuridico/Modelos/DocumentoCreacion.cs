using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class DocumentoCreacion
    {
        public string establecimientoInformacion { get; set; }
        public string numero { get; set; }
        public string fecha { get; set; }
        public string autoriza { get; set; }
        public List<int> tipoModificacion { get; set; }
    }

}