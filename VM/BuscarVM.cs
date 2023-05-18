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

        public DateTime Data { get { return _fechaFin; } set { _fechaFin = value; OnPropertyChanged(); } }
        private DateTime _fechaFin;

        public BuscarVM()
        {
            var poblacions = PoblacionDAO.GetPoblaciones();
            LPob = new ObservableCollection<Poblacion>(poblacions);
            OnPropertyChanged("LPob");

            Data = DateTime.Now;
        }

        public bool buscar()
        {
            List<Viaje> list = UsuarioDAO.getAllViajes();
            List<Viaje> list2 = new List<Viaje>();
            foreach (var item in list)
            {
                if (item != null)
                {
                    if (item.Destino.CodigoPostal == PobLlegada.CodigoPostal)
                    {
                        if (item.Origen.CodigoPostal == PobSalida.CodigoPostal)
                        {
                            /*
                            if (item.FechaInicio.Year == Data.Year)
                            {
                                if (item.FechaInicio.Month == Data.Month)
                                {
                                    if (item.FechaInicio.Day == Data.Day)
                                    {
                                        list2.Add(item);
                                    }
                                }
                            }
                            */
                            if (item.FechaInicio.Year >= Data.Year && item.FechaFin.Year >= Data.Year)
                            {
                                if (item.FechaInicio.Month >= Data.Month && item.FechaFin.Month >= Data.Month)
                                {
                                    if (item.FechaInicio.Day <= Data.Day && item.FechaFin.Day <= Data.Day)
                                    {
                                        list2.Add(item);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (list2.Count > 0)
            {
                Config.ViajeList = list2;
                return true;
            }
            return false;
        }
    }
}
