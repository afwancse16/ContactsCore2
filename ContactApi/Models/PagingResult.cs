using System.Collections.Generic;
using ContactApi.Dto;

namespace ContactApi.Models
{
    public class PagingResult
    {
        public IEnumerable<ContactDto> Data { get; set; }

        public int Total { get; set; }
    }
}