using System.Collections.Generic;

namespace Repositories.Contracts
{
    public interface ICursoContract<T>
    {
        List<T> GetALL();
        T GetCurso(int id);
        bool SaveCurso(T model);
        bool UpdateCurso(T model, int id);
        void DeleteCurso(int id);
    }
}