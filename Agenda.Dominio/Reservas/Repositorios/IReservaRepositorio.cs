using Agenda.Dominio.Reservas.Entidades;
using Libraries.Dominio.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Reservas.Repositorios
{
    public interface IReservaRepositorio : IRepositorioNHibernate<Reserva>
    {
    }
}
