using IscaCar.Helpers;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace IscaCar.Model
{
    [Table("DiaSetmana")]
    public class DiaSetmana : Base
    {
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private int _id;

        public String Dia { get { return _dia; } set { _dia = value; OnPropertyChanged(); } }
        private String _dia;

        public TimeSpan Salida { get { return _salida; } set { _salida = value; OnPropertyChanged();  } }
        private TimeSpan _salida;

        public TimeSpan Llegada { get { return _llegada; } set { _llegada = value; OnPropertyChanged(); } }
        private TimeSpan _llegada;

        [ManyToOne]
        public Viaje Viaje { get { return _viaje; } set { _viaje = value; OnPropertyChanged(); } }
        private Viaje _viaje;
    }
}