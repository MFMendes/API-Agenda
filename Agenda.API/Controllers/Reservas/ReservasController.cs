using Agenda.Aplicacao.Reservas.Servicos;
using Agenda.DataTransfer.Reservas.Requests;
using Agenda.DataTransfer.Reservas.Responses;
using Libraries.Dominio.Consultas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda.API.Controllers.Reservas
{
    [Route("reservas")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly IReservasAppServico reservasAppServico;

        public ReservasController(IReservasAppServico reservasAppServico)
        {
            this.reservasAppServico = reservasAppServico;
        }

        ///<summary>
        /// Listar Reservas
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpGet]
        //[Authorize]
        public ActionResult<PaginacaoConsulta<ReservaResponse>> ListarReservas([FromQuery] ReservaListarRequest request)
        {
            var response = reservasAppServico.Listar(request);

            return Ok(response);
        }
    }
}
