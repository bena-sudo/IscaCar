using IscaCar.Helpers;

namespace IscaCar.Model
{
    public class Viaje : Base
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }

        private Usuario _usuario;
        public Usuario Usuario { get { return _usuario; } set { _usuario = value; OnPropertyChanged(); } }

        private int _plazas;
        public int Plazas { get { return _plazas; } set { _plazas = value; OnPropertyChanged(); } }

        private DateTime _fechaInicio;
        public DateTime FfechaInicio { get { return _fechaInicio; } set { _fechaInicio = value; OnPropertyChanged(); } }

        private DateTime _fechaFin;
        public DateTime FechaFin { get { return _fechaFin; } set { _fechaFin = value; OnPropertyChanged(); } }



        private List<DiaSetmana> _diaSetmana;
        public List<DiaSetmana> DiasSetmana { get { return _diaSetmana; } set { _diaSetmana = value; OnPropertyChanged(); } }

        private Poblacion _origen;
        public Poblacion Origen { get { return _origen; } set { _origen = value; OnPropertyChanged(); } }

        private Poblacion _destino;
        public Poblacion Destino { get { return _destino; } set { _destino = value; OnPropertyChanged(); } }

        private string _observaciones;
        public string Observaciones { get { return _observaciones; } set { _observaciones = value; OnPropertyChanged(); } }
    }
}