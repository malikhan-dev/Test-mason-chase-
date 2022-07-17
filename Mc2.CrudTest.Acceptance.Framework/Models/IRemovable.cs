using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc2.CrudTest.Acceptance.Framework.Models
{
    public interface IRemovable
    {
        public bool IsDeleted { get; set; }
    }
}
