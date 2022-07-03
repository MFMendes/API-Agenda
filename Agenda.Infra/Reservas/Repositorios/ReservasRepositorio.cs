using Agenda.Dominio.Reservas.Entidades;
using Agenda.Dominio.Reservas.Repositorios;
using Libraries.NHibernate.Repositorios;
using NHibernate;
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
    }
}
