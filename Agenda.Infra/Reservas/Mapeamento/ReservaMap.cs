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
            References(x => x.Local).Column("ID_LOCAL").Not.Nullable();
            References(x => x.Disciplina).Column("ID_DISCIPLINA").Nullable();
            References(x => x.Turma).Column("ID_TURMA").Nullable();
            Map(x => x.Responsavel).Column("RESPONSAVEL").Nullable();
            Map(x => x.DataInicio).Column("DATAINICIO").CustomSqlType("Time").Not.Nullable();
            Map(x => x.HoraInicio).Column("HORAINICIO").CustomSqlType("Time").Not.Nullable();
            Map(x => x.HoraFim).Column("HORAFIM").Not.Nullable();
            Map(x => x.Descricao).Column("DESCRICAO").Nullable();
            Map(x => x.DeleteAt).Column("DELETEAT").Nullable();
        }
    }
}
