using IscaCar.Helpers;

namespace IscaCar.Model
{
    public class Poblacion : Base
    {
        public string Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private string _id;

        public string Nombre { get { return _nombre; } set { _nombre = value; OnPropertyChanged(); } }
        private string _nombre;

        public string CodigoPostal { get {  return _codigoPostal; } set { _codigoPostal = value; OnPropertyChanged(); } }
        private string _codigoPostal;

    }
}