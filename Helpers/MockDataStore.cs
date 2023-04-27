using IscaCar.Model;

namespace IscaCar.Helpers
{
    public class MockDataStore
    {
        readonly List<Usuario> items;

        public MockDataStore()
        {
            items = new List<Usuario>()
            {
                new Usuario { Id = Guid.NewGuid().ToString(), Correo = "Pepe", Password="Pepe" }
            };
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

        public async Task<bool> AddUsuarioAsync(Usuario item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> FindUsuarioAsync(Usuario usuario)
        {
            var oldItem = items.Where((Usuario arg) => arg.Correo == usuario.Correo).FirstOrDefault();
            if (oldItem != null)
            {
                if (oldItem.Password == usuario.Password)
                {
                    return await Task.FromResult(true);
                }
            }
            return await Task.FromResult(false);
        }
    }
}