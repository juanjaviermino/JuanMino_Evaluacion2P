namespace JuanMino_Evaluacion2P;

public partial class RecargaPage : ContentPage
{
	string cantidad;

	public RecargaPage()
	{
		InitializeComponent();
		BindingContext = this;
		cantidad = " ";
	}

	private void Cambio(object sender, CheckedChangedEventArgs e)
	{
		if(JMTres.IsChecked == true)
		{
			JMRecargaSeleccionada.Text = "Ha seleccionado una recarga de: $3.00";
			cantidad = "¿Desea recargar $3.00?";
		}
        if (JMCinco.IsChecked == true)
        {
            JMRecargaSeleccionada.Text = "Ha seleccionado una recarga de: $5.00";
            cantidad = "¿Desea recargar $5.00?";
        }
        if (JMDiez.IsChecked == true)
        {
            JMRecargaSeleccionada.Text = "Ha seleccionado una recarga de: $10.00";
            cantidad = "¿Desea recargar $10.00?";
        }
    }

	private async void JMRecargar(object sender, EventArgs e)
	{	

		if(string.IsNullOrEmpty(JMTelefono.Text))
		{
            await DisplayAlert("Alerta", "Porfavor, ingrese un número de teléfono", "OK");
		}
		else if (JMTres.IsChecked != true && JMCinco.IsChecked != true && JMDiez.IsChecked != true)
		{
            await DisplayAlert("Alerta", "Porfavor, seleccione una cantidad", "OK");
        }
		else if (JMPicker.SelectedItem == null)
		{
            await DisplayAlert("Alerta", "Porfavor, seleccione un operador", "OK");
        }
		else
		{
			string mensaje = "Recarga exitosa realizada al número " + JMTelefono.Text + " [" + JMPicker.SelectedItem + "]";
            bool respuesta = await DisplayAlert("Confirmación", cantidad, "Sí", "No");
			if(respuesta == true)
			{
                await DisplayAlert("Finalizado", mensaje, "OK");
            }
        }
        
    }
}