using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Criptografia : Cript
    {
        public string Criptografa(string senha)
        {
            string hash = "";

            SHA1CryptoServiceProvider crypto = new SHA1CryptoServiceProvider();

            try
            {
                byte[] texto = Encoding.Default.GetBytes(senha);

                hash = BitConverter.ToString(crypto.ComputeHash(texto));

                hash = hash.Replace("-", "");

                return hash;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }
    }
}
