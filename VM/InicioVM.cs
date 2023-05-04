using IscaCar.DAO;
using IscaCar.Model;

namespace IscaCar.VM
{
    public class InicioVM
    {
        public InicioVM() 
        {
        }

        public Usuario BuscarUsusario(String correo, String password)
        {
            return UsuarioDAO.BuscarUsuarioAsync(correo,password).Result;
        }
    }
}
