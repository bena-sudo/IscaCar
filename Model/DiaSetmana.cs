using IscaCar.Helpers;

namespace IscaCar.Model
{
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
    }
}