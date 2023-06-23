using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderScanner.Models
{
    public class FolderStatistic
    {
        public Dictionary<string, int> CountType = new Dictionary<string, int>();
        public Dictionary<string, long> TotalSizeType = new Dictionary<string, long>();
    }
}
