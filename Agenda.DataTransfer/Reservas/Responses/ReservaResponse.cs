using Agenda.DataTransfer.Instrutores.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.DataTransfer.Reservas.Responses
{
    public class ReservaResponse
    {
        public virtual int Id { get; protected set; }
        public virtual int IdLocal { get; protected set; }
        public virtual string Titulo { get; protected set; }
        public virtual DateTime DataInicio { get; protected set; }
        public virtual string HoraInicio { get; protected set; }
        public virtual string HoraFim { get; protected set; }
        public virtual DateTime? DeleteAt { get; protected set; }
        public virtual string Descricao { get; protected set; }
        public virtual string? Responsavel { get; protected set; }
        public virtual InstrutorResponse Instrutor { get; protected set; }
        public virtual int? IdTurma { get; protected set; }
        public virtual int? IdDisciplina { get; protected set; }
    }
}
