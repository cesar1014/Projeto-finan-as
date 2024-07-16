using Financas.models;
using System.Linq;
using System;

namespace Financas.controller
{
    internal class CategoriasController : DefaultController
    {
        private readonly DataContext _context;

        public CategoriasController(DataContext context)
        {
            _context = context;
        }

        public void CreateCategoria(Categorias categoria)
        {
            try
            {
                _context.Categorias.Add(categoria);
                _context.SaveChanges();
                Console.WriteLine("Categoria criada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar categoria: {ex.Message}");
            }
        }

        public Categorias ReadCategoria(int id)
        {
            try
            {
                var categoria = _context.Categorias.Find(id);
                if (categoria != null)
                {
                    Console.WriteLine($"Categoria encontrada: {categoria.descricao}");
                }
                else
                {
                    Console.WriteLine("Categoria não encontrada.");
                }
                return categoria;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler categoria: {ex.Message}");
                return null;
            }
        }

        public void UpdateCategoria(int id, string novaDescricao)
        {
            try
            {
                var categoria = _context.Categorias.Find(id);
                if (categoria != null)
                {
                    categoria.descricao = novaDescricao;
                    _context.SaveChanges();
                    Console.WriteLine("Categoria atualizada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Categoria não encontrada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar categoria: {ex.Message}");
            }
        }

        public void DeleteCategoria(int id)
        {
            try
            {
                var categoria = _context.Categorias.Find(id);
                if (categoria != null)
                {
                    _context.Categorias.Remove(categoria);
                    _context.SaveChanges();
                    Console.WriteLine("Categoria removida com sucesso.");
                }
                else
                {
                    Console.WriteLine("Categoria não encontrada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover categoria: {ex.Message}");
            }
        }
    }
}
