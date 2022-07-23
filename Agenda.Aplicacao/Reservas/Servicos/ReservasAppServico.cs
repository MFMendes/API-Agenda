using Agenda.DataTransfer.Reservas.Requests;
using Agenda.DataTransfer.Reservas.Responses;
using Agenda.Dominio.Reservas.Entidades;
using Agenda.Dominio.Reservas.Repositorios;
using AutoMapper;
using Libraries.Dominio.Consultas;
using System.Collections.Generic;

namespace Agenda.Aplicacao.Reservas.Servicos
{
    public class ReservasAppServico : IReservasAppServico
    {
        private readonly IReservaRepositorio reservaRepositorio;
        private readonly IMapper mapper;

        public ReservasAppServico(IMapper mapper, IReservaRepositorio reservaRepositorio)
        {
            this.mapper = mapper;
            this.reservaRepositorio = reservaRepositorio;
        }

        public PaginacaoConsulta<ReservaResponse> Listar(ReservaListarRequest request)
        {

            var query = reservaRepositorio.Query();

            PaginacaoConsulta<Reserva> reserva = reservaRepositorio.Listar(query, request.Qt, request.Pg, request.CpOrd, request.TpOrd);

            PaginacaoConsulta<ReservaResponse> resultado = mapper.Map<PaginacaoConsulta<ReservaResponse>>(reserva);

            return resultado;

        }
    }
}