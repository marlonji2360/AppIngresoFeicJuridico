using System.Collections.Generic; 
namespace AppIngresoFeicJuridico.Modelos{ 

    public class ProductoServicio
    {
        public Lugar lugar { get; set; }
        public string fecha { get; set; }
        public string tipo { get; set; }
        public string nombreDescripcion { get; set; }
        public string identificador { get; set; }
        public string moneda { get; set; }
        public double valor { get; set; }
        public string empresaPropiedad { get; set; }
        public EmpresaSolicitante empresaSolicitante { get; set; }
        public List<InfoEconomicaEmpresa> infoEconomicaEmpresa { get; set; }
        public string fondosPropios { get; set; }
        public string fondosTercero { get; set; }
        public List<PersonaIndividualProveeFondo> personaIndividualProveeFondos { get; set; }
        public List<PersonaJuridicaProveeFondo> personaJuridicaProveeFondos { get; set; }
        public List<OtrosFirmante> otrosFirmantes { get; set; }
        public List<Beneficiario> beneficiarios { get; set; }
    }

}