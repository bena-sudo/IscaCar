using IscaCar.DAO;
using IscaCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
