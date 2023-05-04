using IscaCar.DAO;
using IscaCar.Helpers;
using IscaCar.Model;

namespace IscaCar.VM
{
    public class RegistrarVM : Base
    {
        public Usuario Usuario { get { return _usuario; } set { _usuario = value; OnPropertyChanged(); } }
        private Usuario _usuario;

        public RegistrarVM() { }
    }
}