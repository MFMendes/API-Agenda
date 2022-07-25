using Agenda.DataTransfer.Reservas.Requests;
using Agenda.DataTransfer.Reservas.Responses;
using Agenda.Dominio.Reservas.Entidades;
using Agenda.Dominio.Reservas.Repositorios;
using Agenda.Dominio.Reservas.Servicos.Interfaces;
using AutoMapper;
using Libraries.Aplicacao.Transacoes.Interfaces;
using Libraries.Dominio.Consultas;
using System;
using System.Collections.Generic;

namespace Agenda.Aplicacao.Reservas.Servicos
{
    public class ReservasAppServico : IReservasAppServico
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IReservaRepositorio reservaRepositorio;
        private readonly IReservasServicos reservasServicos;
        private readonly IMapper mapper;

        public ReservasAppServico(IUnitOfWork unitOfWork, IMapper mapper, IReservaRepositorio reservaRepositorio, IReservasServicos reservasServicos)
        {
            this.reservasServicos = reservasServicos;
            this.unitOfWork = unitOfWork;
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

        public ReservaResponse AdicionarReserva(ReservaInserirRequest request)
        {
            try
            {
                unitOfWork.BeginTransaction();



                reservasServicos.ValidarHorario(request.IdLocal, request.DataInicio, TimeSpan.Parse(request.HoraInicio), TimeSpan.Parse(request.HoraFim));

                //reservaRepositorio.Inserir(reserva);

                //ReservaResponse resultado = mapper.Map<ReservaResponse>(reserva);

                unitOfWork.Commit();

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}