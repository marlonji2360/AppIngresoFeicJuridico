using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class DatosRepresentante
    {
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string otrosNombres { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string apellidoCasada { get; set; }
        public string tipoDocumentoIdentificacion { get; set; }
        public string numeroDocumentoIdentificacion { get; set; }
        public string emisionPasaporte { get; set; }
        public string nit { get; set; }
        public string sexo { get; set; }
        public string fechaNacimiento { get; set; }
        public string direccionResidencia { get; set; }
        public Residencia residencia { get; set; }
        public int zona { get; set; }
        public Nacimiento nacimiento { get; set; }
        public string condicionMigratoria { get; set; }
        public string otraCondicionMigratoria { get; set; }
        public List<string> nacionalidades { get; set; }
        public string estadoCivil { get; set; }
        public string profesionOficio { get; set; }
        public List<long> telefonos { get; set; }
        public string email { get; set; }
        public string pep { get; set; }
        public List<DatosPep> datosPep { get; set; }
        public string parientePep { get; set; }
        public List<DatosParientePep> datosParientePep { get; set; }
        public string asociadoPep { get; set; }
        public List<DatosAsociadoPep> datosAsociadoPep { get; set; }
    }

}