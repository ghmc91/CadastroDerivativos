using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDerivativos.Domain.Entities.ApiResult
{
    public class ApiResult<T>
    {
        public List<T> Data { get; set; }

        private ApiResult(List<T> data)
        {
            Data = data;
        }

        public static ApiResult<T> CreateAsync(List<T> data)
        {
            return new ApiResult<T>(data);
        }
    }
}
