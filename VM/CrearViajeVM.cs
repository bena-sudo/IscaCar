using IscaCar.Helpers;
using IscaCar.Model;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IscaCar.VM
{
    public class CrearViajeVM : Base
    {
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
    }
}
