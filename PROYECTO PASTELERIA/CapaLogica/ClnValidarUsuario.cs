using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ClnValidarUsuario
    {
        public bool VerificarCredenciales(string username, string password)
        {
            using (var context = new BDPASTELERIAEntities())
            {
                var usuario = context.Usuario.FirstOrDefault(x => x.Usuario1 == username);
                if(usuario != null)
                {
                    byte[] contraseñaCifrada = CifrarContraseña(password);
                    return usuario.Clave.SequenceEqual(contraseñaCifrada);
                }
                else
                {
                    return false;
                }
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
