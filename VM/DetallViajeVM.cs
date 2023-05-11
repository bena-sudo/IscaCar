using IscaCar.Helpers;
using IscaCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IscaCar.VM
{
    public class DetallViajeVM : Base
    {
        private Viaje _viaje;
        public Viaje Viaje { get { return _viaje; } set { _viaje = value; OnPropertyChanged(); } }

        public DetallViajeVM() { }
    }
}
