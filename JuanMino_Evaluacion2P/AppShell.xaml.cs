namespace JuanMino_Evaluacion2P;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(RecargaPage), typeof(RecargaPage));
    }
}
