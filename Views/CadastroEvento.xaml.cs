using MauiAppEvento.Models;

namespace MauiAppEvento.Views;

public partial class CadastroEvento : ContentPage
{
    App PropriedadesApp;

    public CadastroEvento()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

        dtpck_datainicio.MinimumDate = DateTime.Now;
        dtpck_datainicio.MaximumDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month, DateTime.Now.Day);

		dtpck_datatermino.MinimumDate = dtpck_datainicio.Date;
        dtpck_datatermino.MaximumDate = dtpck_datainicio.Date.AddMonths(1);

    }

    private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Evento evento = new Evento
			{
				Nome = Convert.ToString(txt_nome.Text),
				Local = Convert.ToString(txt_local.Text),
				DataInicio = dtpck_datainicio.Date,
				DataTermino = dtpck_datatermino.Date,
				NumeroParticipantes = Convert.ToInt32(qtd_participantes.Text),
				CustoParticipante = Convert.ToDouble(txt_custo.Text),
			};
			await Navigation.PushAsync(new ResumoEvento()
			{
				BindingContext = evento,
			});
		}
		catch (Exception ex)
		{

			await DisplayAlert("Ops", ex.Message, "OK");
		}
	}
}