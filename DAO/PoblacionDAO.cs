using IscaCar.Helpers;
using IscaCar.Model;

namespace IscaCar.DAO
{
    public static class PoblacionDAO
    {
        private static MockDataStore store = new MockDataStore();
        public static List<Poblacion> GetPoblaciones()
        {
            return store.GetAllPoblaciones();
        }
        
    }
}
