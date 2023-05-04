using IscaCar.Helpers;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace IscaCar.Model
{
    [Table("DiaSetmana")]
    public class DiaSetmana : Base
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }

        private DateTime _dia;
        public DateTime Dia { get { return _dia; } set { _dia = value; OnPropertyChanged(); } }

        private TimeOnly _salida;
        public TimeOnly Salida { get { return _salida; } set { _salida = value; OnPropertyChanged();  } }

        private TimeOnly _llegada;
        public TimeOnly Llegada { get { return _llegada; } set { _llegada = value; OnPropertyChanged(); } }

        [ManyToOne]
        public Viaje Viaje { get { return _viaje; } set { _viaje = value; OnPropertyChanged(); } }
        private Viaje _viaje;
    }
}