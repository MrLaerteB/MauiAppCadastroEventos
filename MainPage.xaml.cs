using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSalvarClicked(object sender, EventArgs e)
    {
        // Exibe os dados do evento em um alerta
        var evento = (Evento)BindingContext;
        DisplayAlert("Evento cadastrado!",
            $"Nome: {evento.Nome}\nInício: {evento.DataInicio.ToShortDateString()}\nFim: {evento.DataFim.ToShortDateString()}\n" +
            $"Participantes: {evento.NumeroParticipantes}\nCusto/Participante: {evento.CustoPorParticipante:C2}\n" +
            $"Duração: {evento.DuracaoEvento} dias\nCusto Total: {evento.CustoTotal:C2}",
            "OK");
    }
}
