﻿using IscaCar.Helpers;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.ObjectModel;

namespace IscaCar.Model
{
    [Table("Viaje")]
    public class Viaje : Base
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get { return _id; } set { _id = value; OnPropertyChanged(); } }
        private string _id;

        [ManyToOne]
        public Usuario Usuario { get { return _usuario; } set { _usuario = value; OnPropertyChanged(); } }
        private Usuario _usuario;

        public int Plazas { get { return _plazas; } set { _plazas = value; OnPropertyChanged(); } }
        private int _plazas;

        public DateTime FechaInicio { get { return _fechaInicio; } set { _fechaInicio = value; OnPropertyChanged(); } }
        private DateTime _fechaInicio;

        public DateTime FechaFin { get { return _fechaFin; } set { _fechaFin = value; OnPropertyChanged(); } }
        private DateTime _fechaFin;

        [OneToMany]
        public ObservableCollection<DiaSetmana> DiasSetmana { get { return _diaSetmana; } set { _diaSetmana = value; OnPropertyChanged(); } }
        private ObservableCollection<DiaSetmana> _diaSetmana;

        public Poblacion Origen { get { return _origen; } set { _origen = value; OnPropertyChanged(); } }
        private Poblacion _origen;

        public Poblacion Destino { get { return _destino; } set { _destino = value; OnPropertyChanged(); } }
        private Poblacion _destino;

        public string Observaciones { get { return _observaciones; } set { _observaciones = value; OnPropertyChanged(); } }
        private string _observaciones;

        public List<Poblacion> LPob { get { return _lpob; } set { _lpob = value; OnPropertyChanged(); } }
        private List<Poblacion> _lpob;

        public Viaje()
        {
            DiasSetmana = new ObservableCollection<DiaSetmana>();
            LPob = new List<Poblacion>();
        }
    }
}