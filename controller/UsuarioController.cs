using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financas.models;
using System.Security.Cryptography;

namespace Financas.controller
{
    public class UsuarioController : DefaultController
    {
        private readonly DataContext _context;

        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        public void CreateUsuario(Usuario usuario)
        {
            try
            {
                var existingUsuario = _context.Usuario.FirstOrDefault(u => u.usuario == usuario.usuario);
                if (existingUsuario != null)
                {
                    Console.WriteLine("Usuário já existe.");
                    return;
                }

                usuario.senha = ComputeSha256Hash(usuario.senha);
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
                Console.WriteLine("Usuário criado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar usuário: {ex.Message}");
            }
        }

        public Usuario ReadUsuario(string usuarioNome)
        {
            try
            {
                var usuario = _context.Usuario.FirstOrDefault(u => u.usuario == usuarioNome);
                if (usuario != null)
                {
                    Console.WriteLine($"Usuário encontrado: {usuario.usuario}");
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado.");
                }
                return usuario;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao ler usuário: {ex.Message}");
                return null;
            }
        }

        public void UpdateUsuario(string usuarioNome, string novaSenha)
        {
            try
            {
                var usuario = _context.Usuario.FirstOrDefault(u => u.usuario == usuarioNome);
                if (usuario != null)
                {
                    usuario.senha = ComputeSha256Hash(novaSenha);
                    _context.SaveChanges();
                    Console.WriteLine("Senha do usuário atualizada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar usuário: {ex.Message}");
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
