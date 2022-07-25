using Agenda.Dominio.Locais.Entidades;
using Agenda.Dominio.Reservas.Entidades;
using Agenda.Dominio.Reservas.Repositorios;
using Libraries.NHibernate.Repositorios;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infra.Reservas.Repositorios
{
    public class ReservasRepositorio : RepositorioNHibernate<Reserva>, IReservaRepositorio
    {
        public ReservasRepositorio(ISession session) : base(session)
        {
        }

        public bool LocalOcupado(Local local, DateTime dataInicio, TimeSpan horaInicio, TimeSpan horaFim)
        {
            var reserva = session.CreateCriteria<Reserva>()
                            .Add(Expression.Eq("Local", local))
                            .Add(Expression.Eq("DataInicio", dataInicio))
                            .Add(Expression.Sql("(( '"+ horaInicio + "' BETWEEN HoraInicio AND HoraFim) " +
                                                "OR ('" + horaFim + "' BETWEEN HoraInicio AND HoraFim) " +
                                                "OR (HoraInicio BETWEEN '" + horaInicio + "' AND '" + horaFim + "') " +
                                                "OR (HoraFim BETWEEN '" + horaInicio + "' AND '" + horaFim + "'))"))
                            .List<Reserva>();

            return reserva.Count > 0 ? true : false;
        }
    }
}
