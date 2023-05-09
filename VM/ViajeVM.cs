using IscaCar.Helpers;
using IscaCar.Model;
using System.Collections.ObjectModel;

namespace IscaCar.VM
{
    public class ViajeVM : Base
    {
        private ObservableCollection<Viaje> _lviaj;
        public ObservableCollection<Viaje> LViaj { get { return _lviaj; } set { _lviaj = value; OnPropertyChanged(); } }

        public ViajeVM() 
        {
            LViaj = new ObservableCollection<Viaje>(Config.usuario.Viajes);
        }
    }
}
