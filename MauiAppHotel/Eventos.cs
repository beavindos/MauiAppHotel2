using System;

namespace MauiAppHotel.Models
{
    public class Evento
    {
        // Propriedades básicas (com valores padrão para evitar avisos CS8618)
        public string Nome { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public int NumeroParticipantes { get; set; }
        public string Local { get; set; } = string.Empty;
        public decimal CustoPorParticipante { get; set; }

        // Propriedade calculada: custo total
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;

        // Propriedade calculada: duração em dias
        public int DuracaoEmDias => (DataFim - DataInicio).Days + 1;
    }
}

