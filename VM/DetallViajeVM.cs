using IscaCar.Helpers;
using IscaCar.Model;

namespace IscaCar.VM
{
    public class DetallViajeVM : Base
    {
        public Viaje Viaje { get { return _viaje; } set { _viaje = value; OnPropertyChanged(); } }
        private Viaje _viaje;

        public DetallViajeVM() {
       
                }
    }
}
