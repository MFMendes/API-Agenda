using Agenda.Dominio.Instrutores.Entidades;
using System;

namespace Agenda.DataTransfer.Reservas.Requests
{
    public class ReservaInserirRequest
    {
        public int IdLocal { get; set; }
        public string Titulo { get; set; }
        public string Responsavel { get; set; }
        public DateTime DataInicio { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public DateTime? DeleteAt { get; set; }
        public string Descricao { get; set; }
        public int? Instrutor { get; set; }
        public int? IdTurma { get; set; }
        public int? IdDisciplina { get; set; }
    }
}
