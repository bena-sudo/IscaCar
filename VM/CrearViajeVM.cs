using IscaCar.DAO;
using IscaCar.Helpers;
using IscaCar.Model;
using System.Collections.ObjectModel;

namespace IscaCar.VM
{
    public class CrearViajeVM : Base
    {
        public ObservableCollection<Poblacion> LPob { get { return _lPobl; } set { _lPobl = value; OnPropertyChanged(); } }
        private ObservableCollection<Poblacion> _lPobl;

        public int IndexPobSalida { get { return _indexPobSalida; } set { _indexPobSalida = value; OnPropertyChanged(); } }
        private int _indexPobSalida;

        public int IndexPobLlegada { get { return _indexPobLlegada; } set { _indexPobLlegada = value; OnPropertyChanged(); } }
        private int _indexPobLlegada;

        public int Plazas { get { return _plazas; } set { _plazas = value; OnPropertyChanged(); } }
        private int _plazas;

        public DateTime FechaInicio { get { return _fechaInicio; } set { _fechaInicio = value; OnPropertyChanged(); } }
        private DateTime _fechaInicio;

        public DateTime FechaFin { get { return _fechaFin; } set { _fechaFin = value; OnPropertyChanged(); } }
        private DateTime _fechaFin;

        public List<DiaSetmana> DiasSetmana { get { return _diaSetmana; } set { _diaSetmana = value; OnPropertyChanged(); } }
        private List<DiaSetmana> _diaSetmana;
        
        public Poblacion Origen { get { return _origen; } set { _origen = value; OnPropertyChanged(); } }
        private Poblacion _origen;

        public Poblacion Destino { get { return _destino; } set { _destino = value; OnPropertyChanged(); } }
        private Poblacion _destino;

        public string Observaciones { get { return _observaciones; } set { _observaciones = value; OnPropertyChanged(); } }
        private string _observaciones;
        
        public CrearViajeVM()
        {
            var poblacions = PoblacionDAO.GetPoblaciones();
            LPob = new ObservableCollection<Poblacion>(poblacions);
            FechaInicio = DateTime.Now;
            FechaFin = DateTime.Now;
        }

        public void crearViaje()
        {
            Viaje viaje = new Viaje();
            viaje.Usuario = Config.usuario;
            viaje.Origen = Origen;
            viaje.Destino = Destino;
            viaje.FechaInicio = FechaInicio;
            viaje.FechaFin = FechaFin;
            viaje.Plazas = Plazas;
            viaje.Observaciones = Observaciones;

            UsuarioDAO.AddViaje(viaje);
        }
    }
} 