using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    public interface ISoftDeletable
    {
        string? deleted { get; set; }
    }
}
