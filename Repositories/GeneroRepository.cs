using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// Ou seja, vamos imple,emtar os métodos, toda a lógica dos métodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// Variável privada e somente leitura que "Guarda" os dados do contexto
        /// </summary>
        private readonly Filmes_Context _context;

        /// <summary>
        /// Construtor do repositório
        /// Aqui, toda vez que o construtor for chamado, os dados do contexto estarão disponíveis
        /// </summary>
        /// <param name="contexto">Dados do Contexto</param>

        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;
        }

        public void Atualizar(Guid id, Genero genero)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                if (generoBuscado != null)
                {
                    generoBuscado.Nome = genero.Nome;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Genero BuscarPorID(Guid id)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;
                return generoBuscado;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método para cadastrar um novo gênero
        /// </summary>
        /// <param name="novoGenero">Objeto gênero a ser cadastrado</param>
        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //Adiciona um novo gênero na tabela Generos(BD)
                _context.Genero.Add(novoGenero);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //ctrl + k + c: atalho para comentar o código
        //ctrl + k + d: atalho para arrumar o código

        public void Deletar(Guid id)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                if (generoBuscado != null)
                {
                    _context.Genero.Remove(generoBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
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
}
