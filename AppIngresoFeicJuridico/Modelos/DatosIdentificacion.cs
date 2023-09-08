using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class DatosIdentificacion
    {
        public string entidadFormacion { get; set; }
        public string nit { get; set; }
        public string tipoEntidad { get; set; }
        public string detalleTipoEntidad { get; set; }
        public string otroTipoEntidad { get; set; }
        public string fechaInscripcion { get; set; }
        public string paisJurisdiccionConstitucion { get; set; }
        public string nombreRazonSocial { get; set; }
        public string nombreComercial { get; set; }
        public string direccionSocial { get; set; }
        public Lugar lugar { get; set; }
        public int zona { get; set; }
        public List<int> telefonos { get; set; }
        public string email { get; set; }
        public string sitioWeb { get; set; }
        public SociedadMercantil sociedadMercantil { get; set; }
        public OtroTipoSociedad otroTipoSociedad { get; set; }
    }

}