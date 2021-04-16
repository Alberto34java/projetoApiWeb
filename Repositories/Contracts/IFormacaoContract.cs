using System.Collections.Generic;

namespace Repositories.Contracts
{
    public interface IFormacaoContract<T>
    {
        List<T> GetALL();
        T GetFormacao(int id);
        T SaveFormacao(T model);
        void DeleteFormacao(int id);
    }
}