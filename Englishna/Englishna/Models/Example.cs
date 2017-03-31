using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Englishna.Models
{
    public class Example
    {
        public string ExampleStr { get; set; }
        public ICollection<Tag> Tags{ get; set; }
        public string Description{ get; set; }
        public ExampleType ExampleType{ get; set; }
    }
}