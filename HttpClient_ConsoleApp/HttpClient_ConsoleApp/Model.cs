using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient_ConsoleApp
{
    public class Model
    {
        public Guid Id { get; set; }
        public byte Byte { get; set; }
        public string String { get; set; }
        public IList<Guid> GuidList { get; set; }
        public DateTime Date { get; set; }
        public bool Boolean { get; set; }
        public int? Index { get; set; }
        public Foo1 Foo1 { get; set; }
        public Foo2[] Fooes { get; set; }
    }

    public class Foo1
    {
        public string Str { get; set; }
        public IEnumerable<int> Ints { get; set; }

    }

    public class Foo2
    {
        public string Foo { get; set; }
    }
}
