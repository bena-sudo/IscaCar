using IscaCar.Helpers;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace IscaCar.Model
{
    [Table("Usuario")]
    public class Usuario : Base
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private string _id;

        public string Correo { get { return _correo; } set { _correo = value; OnPropertyChanged(); } }
        private string _correo;

        public string Password { get { return _password; } set { _password = value; OnPropertyChanged(); } }
        private string _password;

        [OneToMany]
        public List<Viaje> Viajes { get { return _viajes; } set { _viajes = value; OnPropertyChanged(); } }
        private List<Viaje> _viajes;

    }
}