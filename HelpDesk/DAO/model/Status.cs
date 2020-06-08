using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.model
{
   public class Status:ICadastro
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public int GetId()
        {
            return this.Id;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }
    }
}
