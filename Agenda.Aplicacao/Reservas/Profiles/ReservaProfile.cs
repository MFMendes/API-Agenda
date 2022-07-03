using Agenda.DataTransfer.Reservas.Responses;
using Agenda.Dominio.Reservas.Entidades;
using AutoMapper;
using Libraries.Dominio.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Aplicacao.Reservas.Profiles
{
    public class ReservaProfile : Profile
    {
        public ReservaProfile()
        {
            CreateMap<Reserva, ReservaResponse>();
            CreateMap<PaginacaoConsulta<Reserva>, PaginacaoConsulta<ReservaResponse>>();
        }
    }
}
