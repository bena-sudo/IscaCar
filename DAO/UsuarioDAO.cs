using IscaCar.Helpers;
using IscaCar.Model;

namespace IscaCar.DAO
{
    public static class UsuarioDAO
    {
        private static MockDataStore store = new MockDataStore();

        public static async Task<Usuario> BuscarUsuarioAsync(String correo, String password)
        {
            Usuario res = await store.FindUsuarioAsync(correo,password);
            return res;
        }

        public static async Task<bool> AddUsuarioAsync(String correo, String password)
        {
            bool res = await store.AddUsuarioAsync(correo, password);
            return res;
        }

        public static void AddViaje(Viaje viaje)
        {
            store.AddViaje(viaje);
        }

        public static List<Viaje> getAllViajes()
        {
            return store.getAllViajes();
        }
    }
}