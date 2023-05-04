using IscaCar.Helpers;
using IscaCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
