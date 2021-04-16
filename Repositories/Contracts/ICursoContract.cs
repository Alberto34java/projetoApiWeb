using System.Collections.Generic;

namespace Repositories.Contracts
{
    public interface ICursoContract<T>
    {
        List<T> GetALL();
        T GetCurso(int id);
        T SaveCurso(T model);
        T UpdateCurso(T model, int id);
        void DeleteCurso(int id);
    }
}