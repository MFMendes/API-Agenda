using Agenda.DataTransfer.Reservas.Requests;
using Agenda.DataTransfer.Reservas.Responses;
using Libraries.Dominio.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Aplicacao.Reservas.Servicos
{
    public interface IReservasAppServico
    {
        PaginacaoConsulta<ReservaResponse> Listar(ReservaListarRequest request);
    }
}
