namespace AppIngresoFeicJuridico.Modelos{ 

    public class OtrosFirmante
    {
        public Lugar lugar { get; set; }
        public string fecha { get; set; }
        public string firmanteRepLegal { get; set; }
        public string repLegal { get; set; }
        public DatosFirmante datosFirmante { get; set; }
        public string relacion { get; set; }
    }

}