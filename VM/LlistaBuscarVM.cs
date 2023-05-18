using IscaCar.Helpers;
using IscaCar.Model;
using System.Collections.ObjectModel;

namespace IscaCar.VM
{
    public class LlistaBuscarVM : Base
    {
        public ObservableCollection<Viaje> LViaj { get { return _lviaj; } set { _lviaj = value; OnPropertyChanged(); } }
        private ObservableCollection<Viaje> _lviaj;

        public LlistaBuscarVM()
        {
            LViaj = new ObservableCollection<Viaje>(Config.ViajeList);
        }
    }
}