using IscaCar.Helpers;

namespace IscaCar.Model
{
    public class Usuario : Base
    {
        private string _id;
        public string Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }

        private string _correo;
        public string Correo { get { return _correo; } set { _correo = value; OnPropertyChanged(); } }

        private string _password;
        public string Password { get { return _password; } set { _password = value; OnPropertyChanged(); } }

        private List<Viaje> _viajes;
        public List<Viaje> Viajes { get { return _viajes; } set { _viajes = value; OnPropertyChanged(); } }

    }
}