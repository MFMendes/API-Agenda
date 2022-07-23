using Libraries.Dominio.Filtros;
using Libraries.Dominio.Filtros.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.DataTransfer.Reservas.Requests
{
    public class ReservaListarRequest : PaginacaoFiltro
    {
        public ReservaListarRequest() : base(cpOrd: "Id", tpOrd: TipoOrdenacaoEnum.Asc)
        {
        }
    }
}
