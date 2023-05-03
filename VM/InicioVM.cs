using IscaCar.DAO;
using IscaCar.Model;

namespace IscaCar.VM
{
    public class InicioVM
    {
        public Usuario Usuario { get; set; }

        public InicioVM() 
        {
        }

        public bool Iniciar()
        {
            bool res = UsuarioDAO.ComprobarAsync(Usuario).Result;
            return res;
        }
    }
}
