using IscaCar.Helpers;
using IscaCar.Model;
using System;

namespace IscaCar.DAO
{
    public static class UsuarioDAO
    {
        private static MockDataStore store = new MockDataStore();
        public static async Task<bool> ComprobarAsync(Usuario usuario)
        {
            
            bool res = await store.FindUsuarioAsync(usuario);
            return res;
        }

        public static async Task<bool> AddUsuario(Usuario usuario)
        {
            bool res = await store.AddUsuarioAsync(usuario);
            return res;
        }
    }
}