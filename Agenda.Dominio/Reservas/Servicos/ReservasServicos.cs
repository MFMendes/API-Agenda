using Agenda.Dominio.Aulas.Repositorios;
using Agenda.Dominio.Disciplinas.Entidades;
using Agenda.Dominio.Disciplinas.Repositorios;
using Agenda.Dominio.Instrutores.Entidades;
using Agenda.Dominio.Instrutores.Repositorios;
using Agenda.Dominio.Locais.Entidades;
using Agenda.Dominio.Locais.Repositorios;
using Agenda.Dominio.Reservas.Entidades;
using Agenda.Dominio.Reservas.Repositorios;
using Agenda.Dominio.Reservas.Servicos.Interfaces;
using Agenda.Dominio.Turmas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dominio.Reservas.Servicos
{
    public class ReservasServicos : IReservasServicos
    {
        public IReservaRepositorio reservaRepositorio { get; set; }
        public IInstrutoresRepositorio instrutoresRepositorio { get; set; }
        public IAulaRepositorio aulaRepositorio { get; set; }
        public ILocaisRepositorio locaisRepositorio { get; set; }
        public IDisciplinasRepositorio disciplinasRepositorio { get; set; }
        public ReservasServicos(IReservaRepositorio reservaRepositorio, ILocaisRepositorio locaisRepositorio)
        {
            this.locaisRepositorio = locaisRepositorio;
            this.reservaRepositorio = reservaRepositorio;
        }

        public Reserva Instanciar(Local local, string titulo,
                        DateTime dataInicio, string horaInicio,
                        string horaFim, DateTime deleteAt,
                        string descricao, Instrutor instrutor, Turma turma,
                        Disciplina disciplina)
        {

            return new Reserva(local, titulo, dataInicio, 
                horaInicio, horaFim, deleteAt, 
                descricao, instrutor, turma, disciplina);
        }

        public bool ValidarHorario(int idlocal, DateTime dataInicio, TimeSpan horaInicio, TimeSpan horaFim)
        {
            Local local = locaisRepositorio.Recuperar(idlocal);

            reservaRepositorio.LocalOcupado(local, dataInicio, horaInicio, horaFim);

            return true;
        }
    }
}
