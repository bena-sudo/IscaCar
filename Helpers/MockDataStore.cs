using IscaCar.Model;
using System.Collections.Generic;

namespace IscaCar.Helpers
{
    public class MockDataStore
    {
        readonly List<Usuario> items;
        readonly List<Poblacion> poblaciones;

        public MockDataStore()
        {
            items = new List<Usuario>()
            {
                new Usuario { Id = Guid.NewGuid().ToString(), Correo = "pepe", Password="pepe" },
                new Usuario { Id = Guid.NewGuid().ToString(), Correo = "paco", Password="paco" }
            };
            poblaciones = new List<Poblacion>()
            {
                new Poblacion { Id = Guid.NewGuid().ToString(), Nombre = "Alberic", CodigoPostal="1234" },
                new Poblacion { Id = Guid.NewGuid().ToString(), Nombre = "Carcer", CodigoPostal="1232" }
            };
        }

        public async Task<bool> AddUsuarioAsync(String correo, String password)
        {
            Usuario usu = new Usuario();
            usu.Id = Guid.NewGuid().ToString();
            usu.Correo = correo;
            usu.Password = password;
            items.Add(usu);
            return await Task.FromResult(true);
        }

        public async Task<Usuario> FindUsuarioAsync(String correo, String password)
        {
            var oldItem = items.Where((Usuario arg) => arg.Correo == correo && arg.Password==password).FirstOrDefault();
            return await Task.FromResult(oldItem);
        }

        public List<Poblacion> GetAllPoblaciones()
        {
            return poblaciones;
        }

        /**
        public async Task<bool> AddItemAsync(Usuario item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Usuario item)
        {
            var oldItem = items.Where((Usuario arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }
        
        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Usuario arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }
        **/
    }
}