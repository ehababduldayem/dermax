using System.Collections.Generic;

namespace Englishna.Models
{
    public interface IExample
    {
        int ExapmleID { get; set; }
        string ExampleText { get; set; }
        ICollection<Tag> Tags{ get; set; }
        string Description{ get; set; }
        ExampleType ExampleType{ get; set; }


    }
}