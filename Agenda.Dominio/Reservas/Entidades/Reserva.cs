﻿using Agenda.Dominio.Instrutores.Entidades;
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
        public virtual int IdLocal { get; protected set; }
        public virtual string Titulo { get; protected set; }
        public virtual string? Responsavel { get; protected set; }
        public virtual DateTime DataInicio { get; protected set; }
        public virtual string HoraInicio { get; protected set; }
        public virtual string HoraFim { get; protected set; }
        public virtual DateTime? DeleteAt { get; protected set; }
        public virtual string Descricao { get; protected set; }
        public virtual Instrutor Instrutor { get; protected set; }
        public virtual int? IdTurma { get; protected set; }
        public virtual int? IdDisciplina { get; protected set; }

        public Reserva() { }
        public Reserva(int idLocal, string titulo, 
                        DateTime dataInicio, string horaInicio,
                        string horaFim, DateTime deleteAt, 
                        string descricao)
        {
            IdLocal = idLocal;
            Titulo = titulo;
            DataInicio = dataInicio;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
            DeleteAt = deleteAt;
            Descricao = descricao;
        }
    }
}
