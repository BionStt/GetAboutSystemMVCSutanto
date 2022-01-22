using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Enum;

namespace Utility
{
    public class AppSettings
    {
        public EditorChoice Editor { get; set; }
        public int PostAbstractWords { get; set; }
        public IDictionary<string, int> CacheSlidingExpirationMinutes { get; set; }
        public bool Pride { get; set; }
    }
}
