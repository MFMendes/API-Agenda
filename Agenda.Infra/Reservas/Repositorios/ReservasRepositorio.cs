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
                            .Add(Expression.Between("HoraInicio", horaInicio, horaFim))
                            .Add(Expression.Between("HoraFim", horaInicio, horaFim))
                            .List<Reserva>();

            //var reserva = session.QueryOver<Reserva>()
            //                .Where(r => r.Local == local)
            //                .And(r => r.DataInicio == dataInicio)
            //                .And(r => TimeSpan.Parse(r.HoraInicio) >= horaInicio)
            //                .And(r => TimeSpan.Parse(r.HoraFim) <= horaInicio)

            return reserva.Count > 0 ? true : false;


        }
    }
}
