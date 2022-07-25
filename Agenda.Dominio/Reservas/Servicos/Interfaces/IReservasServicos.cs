using Agenda.Dominio.Disciplinas.Entidades;
using Agenda.Dominio.Instrutores.Entidades;
using Agenda.Dominio.Locais.Entidades;
using Agenda.Dominio.Reservas.Entidades;
using Agenda.Dominio.Turmas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Reservas.Servicos.Interfaces
{
    public interface IReservasServicos
    {
        Reserva Instanciar(Local local, string titulo,
                        DateTime dataInicio, string horaInicio,
                        string horaFim, DateTime deleteAt,
                        string descricao, Instrutor instrutor, Turma turma,
                        Disciplina disciplina);
        bool ValidarHorario(int idLocal, DateTime dataInicio, TimeSpan horaInicio, TimeSpan horaFim);
    }
}
