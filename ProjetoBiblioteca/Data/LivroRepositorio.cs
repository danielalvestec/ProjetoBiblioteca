using System.Collections.Generic;
using ProjetoBiblioteca.Models;
namespace ProjetoBiblioteca.Data
{
    // A DAL APENAS armazena e recupera dados.Não faz validações nem imprime texto.
    public class LivroRepository
    {
    private static List<Livro>_tabelaLivros = new List<Livro>();
    private static int proximold = 1;
    public void Adicionar(livro livro)
        {
            livro.Id = proximold++;
            _tabelaLivros.Add(livro);
        }
        public List<livro>ObterTodos()
        {
            return_tabelaLivros;
        }
        }
        }