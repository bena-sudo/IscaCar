using IscaCar.Helpers;
using IscaCar.Model;
using System.Collections.ObjectModel;

namespace IscaCar.VM
{
    public class ViajeVM : Base
    {
        public ObservableCollection<Viaje> LViaj { get { return _lviaj; } set { _lviaj = value; OnPropertyChanged(); } }
        private ObservableCollection<Viaje> _lviaj;

        public ViajeVM()
        {
            LViaj = new ObservableCollection<Viaje>(Config.usuario.Viajes);
        }

        public void carregarDades()
        {
            LViaj = new ObservableCollection<Viaje>(Config.usuario.Viajes);
        }
    }
}
