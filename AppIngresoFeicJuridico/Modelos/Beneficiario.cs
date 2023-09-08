namespace AppIngresoFeicJuridico.Modelos{ 

    public class Beneficiario
    {
        public string tipoBeneficiario { get; set; }
        public Lugar lugar { get; set; }
        public string fecha { get; set; }
        public DatosBeneficiarioPI datosBeneficiarioPI { get; set; }
        public string relacion { get; set; }
        public DatosBeneficiarioPJ datosBeneficiarioPJ { get; set; }
        public string nombreCliente { get; set; }
    }

}