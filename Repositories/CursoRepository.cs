using System.Collections.Generic;
using System.Linq;
using data;
using Microsoft.EntityFrameworkCore;
using Models;
using Repositories.Contracts;

namespace Repositories
{
    public class CursoRepository : ICursoContract<Curso>
    {
         private Context _context= new Context();

        public void DeleteCurso(int id)
        {
           var curso= _context.Cursos.Find(id);
           _context.Remove(curso);
            _context.SaveChanges();
        }

        public List<Curso> GetALL()
        {
            return _context.Cursos.ToList();
        }

        public Curso GetCurso(int id)
        {
            var curso= _context.Cursos.Find(id);
            return curso;
        }

        public bool SaveCurso(Curso model)
        {
         
           try
           {
                 _context.Cursos.Add(model);
                 _context.SaveChanges();
                 return true;
               
           }
           catch 
           {
                return false;
           }
        }

        public bool UpdateCurso(Curso model, int id)
        {
           try
           {
               model.Id = id;
               _context.Entry<Curso>(model).State = EntityState.Modified;
               _context.SaveChanges();
               return true;
           }
           catch 
           {
                // TODO
                return false;
           }
        }
    }
}