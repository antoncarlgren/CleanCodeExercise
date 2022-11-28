using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteGenerator.DataReader
{
    interface IDataReader
    {
        Task<string> GetString(string source);
        Task<IEnumerable<string>> GetStringArray(string source);
    }
}
