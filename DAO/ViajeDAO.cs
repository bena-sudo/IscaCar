using IscaCar.Helpers;
using IscaCar.Model;

namespace IscaCar.DAO
{
    public static class ViajeDAO
    {
        private static MockDataStore store = new MockDataStore();

        public static List<Viaje> getAllViajes()
        {
            return store.getAllViajes();
        }

    }
}
