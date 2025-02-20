using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// Classe que vai implementar a interface IgeneroRepository
    /// Ou seja, vamos implementar os métodos , toda a lógica dos métodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        private readonly Filmes_Context _context;
        /// <summary>
        /// Construtor do repositório
        /// Aqui toda vez que o construtor for chamado, os dados do contexto estarão disponiveis
        /// </summary>
        /// <param name="contexto"></param>

        public void Atualizar(Filmes_Context contexto)
        {

            _context = contexto;
        }

        public Genero BucarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Genero novoGenero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
          
            try
            {
                List<Genero> listaGeneros = _context.Genero.ToList();

                return listaGeneros;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public interface IGeneroRepository
    {
        object? Listar();
    }
}
