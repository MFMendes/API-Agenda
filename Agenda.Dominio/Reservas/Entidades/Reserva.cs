using Agenda.Dominio.Disciplinas.Entidades;
using Agenda.Dominio.Instrutores.Entidades;
using Agenda.Dominio.Locais.Entidades;
using Agenda.Dominio.Turmas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Reservas.Entidades
{
    public class Reserva
    {
        public virtual int Id { get; protected set; }
        public virtual Local Local { get; protected set; }
        public virtual string Titulo { get; protected set; }
        public virtual string Responsavel { get; protected set; }
        public virtual DateTime DataInicio { get; protected set; }
        public virtual string HoraInicio { get; protected set; }
        public virtual string HoraFim { get; protected set; }
        public virtual DateTime? DeleteAt { get; protected set; }
        public virtual string Descricao { get; protected set; }
        public virtual Instrutor Instrutor { get; protected set; }
        public virtual Turma Turma { get; protected set; }
        public virtual Disciplina Disciplina { get; protected set; }

        public Reserva() { }
        public Reserva(Local local, string titulo, 
                        DateTime dataInicio, string horaInicio,
                        string horaFim, DateTime deleteAt, 
                        string descricao, Instrutor instrutor, Turma turma,
                        Disciplina disciplina)
        {
            Disciplina = disciplina;
            Turma = turma;
            Instrutor = instrutor;
            Local = local;
            Titulo = titulo;
            DataInicio = dataInicio;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
            DeleteAt = deleteAt;
            Descricao = descricao;
        }
    }
}
