using Financas.view;
using Financas.view.relatorios;
using Financas.models;
using Microsoft.EntityFrameworkCore;
using LoginApp;

namespace Financas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var context = new DataContext())
            {
                bool hasUsers = context.Usuario.Any();
                if (hasUsers)
                {
                    Application.Run(new FormLogin());
                }
                else
                {
                    var registerForm = new FormRegister();
                    Application.Run(registerForm);

                    if (registerForm.RegistroBemSucedido)
                    {
                        Application.Run(new FormLogin());
                    }
                }
            }
        }
    }
}
