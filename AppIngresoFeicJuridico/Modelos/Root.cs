using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class Root
    {
        public EntidadSolicitante entidadSolicitante { get; set; }
        public List<ProductoServicio> productoServicio { get; set; }
    }

}