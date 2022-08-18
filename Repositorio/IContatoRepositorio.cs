using AplicacaoProjetoMVC.Models;

namespace AplicacaoProjetoMVC.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
