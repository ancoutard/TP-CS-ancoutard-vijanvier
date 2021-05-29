using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Initialize
{
    public class ContextDBInitializer : CreateDatabaseIfNotExists<ContextDB>
    {
    }
}
