using IscaCar.DAO;
using IscaCar.Helpers;
using IscaCar.Model;
using System.Collections.ObjectModel;

namespace IscaCar.VM
{
    public class BuscarVM : Base
    {
        public ObservableCollection<Poblacion> LPob { get { return _lPobl; } set { _lPobl = value; OnPropertyChanged(); } }
        private ObservableCollection<Poblacion> _lPobl;

        public int IndexPobSalida { get { return _indexPobSalida; } set { _indexPobSalida = value; OnPropertyChanged(); } }
        private int _indexPobSalida;

        public int IndexPobLlegada { get { return _indexPobLlegada; } set { _indexPobLlegada = value; OnPropertyChanged(); } }
        private int _indexPobLlegada;

        public Poblacion PobSalida { get { return _PobSalida; } set { _PobSalida = value; OnPropertyChanged(); } }
        private Poblacion _PobSalida;

        public Poblacion PobLlegada { get { return _PobLlegada; } set { _PobLlegada = value; OnPropertyChanged(); } }
        private Poblacion _PobLlegada;
        
        public BuscarVM()
        {
            var poblacions = PoblacionDAO.GetPoblaciones();
            LPob = new ObservableCollection<Poblacion>(poblacions);
            OnPropertyChanged("LPob");
        }
    }
}
