using Agenda.Dominio.Aulas.Entidades;
using Agenda.Dominio.Reservas.Entidades;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infra.Reservas.Mapeamentos
{
    public class ReservaMap : ClassMap<Reserva>
    {
        public ReservaMap()
        {
            Table("RESERVAS");
            Id(p => p.Id).Column("ID");
            Map(x => x.Titulo).Column("TITULO").Not.Nullable();
            References(x => x.Instrutor).Column("ID_INSTRUTOR").Nullable();
            Map(x => x.IdLocal).Column("ID_LOCAL").Not.Nullable();
            Map(x => x.IdDisciplina).Column("ID_DISCIPLINA").Nullable();
            Map(x => x.IdTurma).Column("ID_TURMA").Nullable();
            Map(x => x.Responsavel).Column("RESPONSAVEL").Nullable();
            Map(x => x.DataInicio).Column("DATAINICIO").Not.Nullable();
            Map(x => x.HoraInicio).Column("HORAINICIO").Not.Nullable();
            Map(x => x.HoraFim).Column("HORAFIM").Not.Nullable();
            Map(x => x.Descricao).Column("DESCRICAO").Nullable();
            Map(x => x.DeleteAt).Column("DELETEAT").Nullable();
        }
    }
}
