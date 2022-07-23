using Agenda.Dominio.Instrutores.Entidades;
using Agenda.Dominio.Reservas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Aulas.Entidades
{
    public class Aula
    {
        public virtual int Id { get; protected set; }
        public virtual int IdLocal { get; protected set; }
        public virtual string Titulo { get; protected set; }
        public virtual DateTime DataInicio { get; protected set; }
        public virtual string HoraInicio { get; protected set; }
        public virtual string HoraFim { get; protected set; }
        public virtual DateTime? DeleteAt { get; protected set; }
        public virtual string Descricao { get; protected set; }
        public virtual Instrutor Instrutor { get; protected set; }
        public virtual int? IdTurma { get; protected set; }
        public virtual int? IdDisciplina { get; protected set; }

        public Aula(){  }

        public Aula(int idLocal, string titulo, DateTime dataInicio,
                    DateTime horaInicio, DateTime horaFim, DateTime deleteAt,
                    string descricao,
                    Instrutor instrutor, int idTurma, int idDisciplina)
        { 
            SetInstrutor(instrutor);
            SetTurma(idTurma);
            SetDisciplina(idDisciplina);
        }

        public virtual void SetInstrutor(Instrutor instrutor)
        {
            this.Instrutor = instrutor;
        }

        public virtual void SetTurma(int turma)
        {
            this.IdTurma = turma;
        }

        public virtual void SetDisciplina(int disciplina)
        {
            this.IdDisciplina = disciplina;
        }
    }
}
