using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLient.Interfaces
{
    public interface ICrud<T, K>
    {
        Task<JObject> Create(T item);
        Task<JObject> Delete(string itemId);
        JObject Get();
        JObject Get(K itemId);
        Task<JObject> Update(T postUpdate);
    }
}
