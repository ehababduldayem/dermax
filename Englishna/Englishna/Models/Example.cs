using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Englishna.Models
{
    public interface IExample
    {
        string ExampleText { get; set; }
        ICollection<Tag> Tags{ get; set; }
        string Description{ get; set; }
        ExampleType ExampleType{ get; set; }


    }
}