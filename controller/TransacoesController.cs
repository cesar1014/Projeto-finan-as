using Financas.models;
using Financas.models.Financas.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.controller
{
    internal class TransacoesController:DefaultController
    {
        private readonly DataContext _context;

        public TransacoesController(DataContext context)
        {
            _context = context;
        }

        public void CreateTransacao(Transacoes transacao)
        {
            try
            {
                _context.Transacoes.Add(transacao);
                _context.SaveChanges();
                Console.WriteLine("Transação criada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar transação: {ex.Message}");
            }
        }

        public Transacoes ReadTransacao(int id)
        {
            try
            {
                var transacao = _context.Transacoes.Find(id);
                if (transacao != null)
                {
                    Console.WriteLine($"Transação encontrada: {transacao.descricao}");
                }
                else
                {
                    Console.WriteLine("Transação não encontrada.");
                }
                return transacao;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler transação: {ex.Message}");
                return null;
            }
        }

        public void UpdateTransacao(int id, float valor, string descricao, DateTime data, int CategoriaID)
        {
            try
            {
                var transacao = _context.Transacoes.Find(id);
                if (transacao != null)
                {
                    transacao.valor = valor;
                    transacao.descricao = descricao;
                    transacao.data = data;
                    transacao.CategoriaID = CategoriaID;

                    _context.SaveChanges();
                    Console.WriteLine("Transação atualizada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Item não encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar Transação: {ex.Message}");
            }
        }

        public void DeleteTransacao(int id)
        {
            try
            {
                var transacao = _context.Transacoes.Find(id);
                if (transacao != null)
                {
                    _context.Transacoes.Remove(transacao);
                    _context.SaveChanges();
                    Console.WriteLine("Transação removida com sucesso.");
                }
                else
                {
                    Console.WriteLine("Item não encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover a Transação: {ex.Message}");
            }
        }
    }
}
