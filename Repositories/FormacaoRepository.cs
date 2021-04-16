using System.Collections.Generic;
using System.Linq;
using data;
using Models;
using Repositories.Contracts;

namespace Repositories
{
    public class FormacaoRepository : IFormacaoContract<Formacao>
    {
        private Context _context= new Context();

        public void DeleteFormacao(int id)
        {
           var formacao = _context.Formacaos.Find(id);
           _context.Remove(formacao);
           _context.SaveChanges();
        }

        public List<Formacao> GetALL()
        {
            return _context.Formacaos.ToList();
        }

        public Formacao GetFormacao(int id)
        {
           var formacao = _context.Formacaos.Find(id);

           return formacao;
        }

        public bool SaveFormacao(Formacao model)
        {
           try
           {
               _context.Formacaos.Add(model);
               _context.SaveChanges();
               return true;
           }
           catch
           {
               
               return false;
           }
        }
    }
}