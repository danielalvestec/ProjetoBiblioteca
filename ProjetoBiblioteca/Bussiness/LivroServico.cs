using ProjetoBiblioteca.Data;
using ProjetoBiblioteca.Models;
namespace ProjetoBiblioteca.Bussiness
{
    // A BLL contém as REGRAS DE NEGÓCIO e validações
public class LivroService
    {
        private livroRepository_repository = new LivroRepository();
        public bool CadastrarLivro(string titulo,string autor,out string mensagemErro)
        {
            //Regra de Negócio 1: Campos Obrigatórios
            if(string.IsNullOrWhiteSpace(titulo)||string.IsNullOrWhiteSpace(autor))
            {
                mensagemErro = "Título e Autor São Obrigatórios!";
                return false;
            }
            //Regra de Negócio 2:Título precisa ter pelo menos 3 caracteres
            if (titulo.Length < 3){
                mensagemErro = "O Título do Livro Deve Ter No Mínimo 3 Caracteres";
                return false;
            }
            Livro novoLivro = new Livro
            {
                titulo = titulo,
                autor = autor,
                Emprestado = false
            };
            _repository.Adicionar(novoLivro);
            mensagemErro = string.Empty;
            return true;
           }
           public List<livro>ListarAcervo()
        {
            return_repository.ObterTodos();
        }
        }
        }