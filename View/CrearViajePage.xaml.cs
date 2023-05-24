using IscaCar.Helpers;
using IscaCar.Model;
using IscaCar.VM;

namespace IscaCar.View;

public partial class CrearViajePage : ContentPage
{
    public CrearViajeVM vm;
    public CrearViajePage()
    {
        InitializeComponent();
        vm = new CrearViajeVM();
        BindingContext = vm;
    }
    private void continuar(object sender, EventArgs e)
    {
        continuarAsync();
    }
    private async Task continuarAsync()
    {
        if (vm.Origen == null || vm.Destino == null)
        {
            await DisplayAlert("Error", "¡Debe de introducir una poblacion!", "Vale");
        }
        else
        {
            if (vm.IndexPobLlegada == vm.IndexPobSalida)
            {
                await DisplayAlert("Error", "¡La poblacion de origen no puede ser la misma que la de llegada!", "Vale");
            }
            else
            {
                if (vm.FechaInicio.Year >= DateTime.Now.Year)
                {
                    if (vm.FechaInicio.Month >= DateTime.Now.Month)
                    {
                        if (vm.FechaInicio.Day >= DateTime.Now.Day)
                        {
                            if (vm.FechaFin.Year >= vm.FechaInicio.Year)
                            {
                                if (vm.FechaFin.Month >= vm.FechaInicio.Month)
                                {
                                    if (vm.FechaFin.Day > vm.FechaInicio.Day)
                                    {
                                        vm.crearViaje();
                                        await Shell.Current.GoToAsync($"{nameof(CrearViajePage)}");
                                    }
                                    else
                                    {
                                        await DisplayAlert("Error", "¡Debe de introducir una fecha valida!", "Vale");
                                    }
                                }
                                else
                                {
                                    await DisplayAlert("Error", "¡Debe de introducir una fecha valida!", "Vale");
                                }

                            }
                            else
                            {
                                await DisplayAlert("Error", "¡Debe de introducir una fecha valida!", "Vale");
                            }
                        }
                        else
                        {
                            await DisplayAlert("Error", "¡Debe de introducir una fecha valida!", "Vale");
                        }
                    }
                    else
                    {
                        await DisplayAlert("Error", "¡Debe de introducir una fecha valida!", "Vale");
                    }

                }
                else
                {
                    await DisplayAlert("Error", "¡Debe de introducir una fecha valida!", "Vale");
                }
            }
        }
    }

    private void addPoblacio(object sender, EventArgs e)
    {
        addPoblacioAsync();
    }

    private async Task addPoblacioAsync()
    {
        Poblacion p = (Poblacion)ListEsq.SelectedItem;
        if (p != null)
        {
            vm.addPoblacio(p);

        }
        else
        {
            await DisplayAlert("Error", "¡Debes de seleccionar una poblacion!", "Vale");
        }
    }
}