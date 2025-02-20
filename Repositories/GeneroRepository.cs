using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;

namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// Classe que vai implementar a interface IgeneroRepository
    /// Ou seja, vamos implementar os métodos , toda a lógica dos métodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        private readonly Filmes_Context _context;

        public GeneroRepository(Filmes_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BucarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //Adicionar um novo genero na tabela generos(BD)
                _context.Genero.Add(novoGenero);

                //Após o cadastro, salva as alterações(BD)
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
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

        /// <summary>
        /// Construtor do repositório
        /// Aqui toda vez que o construtor for chamado, os dados do contexto estarão disponiveis
        /// </summary>
        /// <param name="contexto"></param>




    }
}
