using System;
using Curso.Data;
using Curso.Domain;
using Curso.ValueObjects;

namespace CursoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            InserirDados();
        }

        private static void InserirDados() {
            var produto = new Produto {
                Descricao = "Produto Teste",
                CodigoBarras = "12345697",
                Valor = 10m,
                TipoProduto = TipoProduto.MercadoriaParaRevenda,
                Ativo = true
            };

            using var db = new ApplicationContext();
            db.Produtos.Add(produto);

            var registros = db.SaveChanges();

            Console.WriteLine(registros);
        }
    }
}
