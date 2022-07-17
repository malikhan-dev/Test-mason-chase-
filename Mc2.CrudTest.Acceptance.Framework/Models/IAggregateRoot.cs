using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Acceptance.Framework.Models
{
    public abstract class AggregateRoot : IRemovable
    {
        public bool IsDeleted { get; set; }

        public bool SoftRemove() => this.IsDeleted = true;
    }
}
