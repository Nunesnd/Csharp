using AplicacaoProjetoMVC.Data;
using AplicacaoProjetoMVC.Models;

namespace AplicacaoProjetoMVC.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.ContatoModels.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}
