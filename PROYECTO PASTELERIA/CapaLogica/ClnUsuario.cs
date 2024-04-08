using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class ClnUsuario
    {
        public void CrearUsuario(string username, string password)
        {
            byte[] ContraseñaCifrada = CifrarContraseña(password);
            using (var context = new BDPASTELERIAEntities())
            {
                var nuevoUsuario = new Usuario
                {
                    Usuario1 = username,
                    Clave = ContraseñaCifrada
                };
                context.Usuario.Add(nuevoUsuario);
                context.SaveChanges();
            }
        }

        private byte[] CifrarContraseña(string contraseña)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contraseña));

                return bytes;
            }
        }
    }
}
