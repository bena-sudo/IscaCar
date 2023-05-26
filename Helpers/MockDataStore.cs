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

            Poblacion i1 = new Poblacion { Id = Guid.NewGuid().ToString(), Nombre = "Carcer", CodigoPostal = "1232" };
            Poblacion i2 = new Poblacion { Id = Guid.NewGuid().ToString(), Nombre = "Alcantera", CodigoPostal = "4555" };
            Poblacion i3 = new Poblacion { Id = Guid.NewGuid().ToString(), Nombre = "Castello", CodigoPostal = "1252" };
            Poblacion i4 = new Poblacion { Id = Guid.NewGuid().ToString(), Nombre = "Tous", CodigoPostal = "2457" };
            Poblacion i5 = new Poblacion { Id = Guid.NewGuid().ToString(), Nombre = "Alberic", CodigoPostal = "1234" };
            Poblacion i6 = new Poblacion { Id = Guid.NewGuid().ToString(), Nombre = "Alzira", CodigoPostal = "9876" };

            poblaciones = new List<Poblacion>()
            {
                i1,i2,i3,i4,i5,i6
            };

            var item = items.First();
            Viaje viaje = new Viaje();
            viaje.Usuario = item;
            viaje.Destino = i5;
            viaje.Origen = i1;
            viaje.Plazas = 2;
            viaje.FechaInicio = new DateTime(2023, 5, 1, 0, 0, 0);
            viaje.FechaFin = new DateTime(2023, 6, 1, 0, 0, 0);
            viaje.Observaciones = "Soy amable";
            viaje.LPob = new List<Poblacion>
            {
                i2
            };

            Viaje viaje2 = new Viaje();
            viaje2.Usuario = item;
            viaje2.Destino = i6;
            viaje2.Origen = i1;
            viaje2.Plazas = 2;
            viaje2.FechaInicio = new DateTime(2023, 5, 1, 0, 0, 0);
            viaje2.FechaFin = new DateTime(2023, 6, 1, 0, 0, 0);
            viaje2.Observaciones = "Soy amable";
            viaje2.LPob = new List<Poblacion>
            {
                i2,i5
            };

            item.Viajes = new List<Viaje>
            {
                viaje,viaje2
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
            var oldItem = items.Where((Usuario arg) => arg.Correo == correo && arg.Password == password).FirstOrDefault();
            return await Task.FromResult(oldItem);
        }

        public List<Poblacion> GetAllPoblaciones()
        {
            return poblaciones;
        }

        public void AddViaje(Viaje item)
        {
            var oldItem = items.Where((Usuario arg) => arg.Correo == item.Usuario.Correo).FirstOrDefault();
            oldItem.Viajes.Add(item);
        }

        public List<Viaje> getAllViajes()
        {
            List<Viaje> lv = new List<Viaje>();
            foreach (var item in items) 
            {
                foreach (var i in item.Viajes)
                {
                    lv.Add(i);
                }
            }
            return lv;
        }

        public void DeleteViaje(Viaje viaje)
        {
            Config.usuario.Viajes.Remove(viaje);
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