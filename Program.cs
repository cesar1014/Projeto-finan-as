using Financas.view;
using Financas.view.relatorios;
using Financas.models;
using Microsoft.EntityFrameworkCore;
using LoginApp;

namespace Financas
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // Inicializa a configuração da aplicação (visual, etc.)
            ApplicationConfiguration.Initialize();

            using (var context = new DataContext())
            {
                //Aplica as migrações pendentes ao banco de dados
                context.Database.Migrate();

                // Verifica se existe algum usuário registrado no banco de dados
                bool hasUsers = context.Usuario.Any();
                if (hasUsers)
                {
                    // Se existirem usuários, abre o formulário de login
                    Application.Run(new FormLogin());
                    //Application.Run(new EntradasSaidas());

                }
                else
                {
                    // Se não existirem usuários, abre o formulário de registro
                    var registerForm = new FormRegister();
                    Application.Run(registerForm);

                    // Se o registro foi bem-sucedido, abre o formulário de login
                    if (registerForm.RegistroBemSucedido)
                    {
                        Application.Run(new FormLogin());
                    }
                }
            }
        }
    }
}
