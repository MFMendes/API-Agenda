using Agenda.DataTransfer.UsuariosAcesso.Requests;
using Agenda.DataTransfer.UsuariosAcesso.Responses;

namespace Agenda.Aplicacao.UsuariosAcesso.Servicos.Interfaces
{
    public interface IUsuariosAcessoAppServico
    {
        UsuarioAcessoResponse Cadastrar(UsuarioAcessoRequest request);
        UsuarioAcessoSessaoResponse Autenticar(UsuarioAcessoAutenticacaoRequest request);
    }
}