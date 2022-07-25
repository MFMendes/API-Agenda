using Agenda.Dominio.Aulas.Repositorios;
using Agenda.Dominio.Disciplinas.Entidades;
using Agenda.Dominio.Disciplinas.Repositorios;
using Agenda.Dominio.Disciplinas.Servicos.Interfaces;
using Agenda.Dominio.Instrutores.Entidades;
using Agenda.Dominio.Instrutores.Repositorios;
using Agenda.Dominio.Instrutores.Servicos.Interfaces;
using Agenda.Dominio.Locais.Entidades;
using Agenda.Dominio.Locais.Repositorios;
using Agenda.Dominio.Locais.Servicos.Interfaces;
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
        public IInstrutorServico instrutoresServico { get; set; }
        public ILocaisServico locaisServico { get; set; }
        public IDisciplinasServico disciplinasServico { get; set; }
        public ReservasServicos(IReservaRepositorio reservaRepositorio, ILocaisServico locaisServico)
        {
            this.locaisServico = locaisServico;
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
            Local local = locaisServico.Validar(idlocal);

            reservaRepositorio.LocalOcupado(local, dataInicio, horaInicio, horaFim);

            return true;
        }
    }
}
