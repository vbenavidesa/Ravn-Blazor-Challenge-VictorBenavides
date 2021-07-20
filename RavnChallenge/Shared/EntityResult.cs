using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavnChallenge.Shared
{
    public class EntityResult<T> : Entity where T : Entity
    {
        public string Previous { get; set; }
        public string Next { get; set; }
        public string PreviousPageNo { get; set; }
        public string NextPageNo { get; set; }
        public long Count { get; set; }
        public List<T> Results { get; set; }
    }
}
