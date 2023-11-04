using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiTracks.API.Models.DTO
{
    public class Response<T>
    {
        public Response()
        {
        }
        public Response(T data)
        {
            Data = data;
            Succeeded = data != null ? true : false;
        }
        public T Data { get; set; }
        public bool Succeeded { get; set; }
    }
}
