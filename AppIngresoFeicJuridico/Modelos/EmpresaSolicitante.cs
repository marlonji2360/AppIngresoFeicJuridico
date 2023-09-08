namespace AppIngresoFeicJuridico.Modelos{ 

    public class EmpresaSolicitante
    {
        public string nombreComercial { get; set; }
        public string paisJurisdiccionConstitucion { get; set; }
        public string nit { get; set; }
        public string direccion { get; set; }
        public Lugar lugar { get; set; }
        public string zona { get; set; }
        public string numeroPatente { get; set; }
        public string folioPatente { get; set; }
        public string libroPatente { get; set; }
    }

}