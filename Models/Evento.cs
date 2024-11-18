namespace MauiAppCadastroEventos.Models;

public class Evento
{
    // Propriedades
    public string Nome { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public int NumeroParticipantes { get; set; }
    public decimal CustoPorParticipante { get; set; }

    // Construtor
    public Evento()
    {
        // Define a data de início e fim como a data atual (hoje)
        DataInicio = DateTime.Today;
        DataFim = DateTime.Today;
    }

    // Propriedade calculada: duração do evento em dias
    public int DuracaoEvento
    {
        get
        {
            return (DataFim - DataInicio).Days;
        }
    }

    // Propriedade calculada: custo total do evento
    public decimal CustoTotal
    {
        get
        {
            return NumeroParticipantes * CustoPorParticipante;
        }
    }
}
