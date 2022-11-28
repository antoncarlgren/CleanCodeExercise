using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteGenerator.DataReader
{
    interface IDataReader
    {
        string GetString(string source);
        IEnumerable<string> GetStringArray(string source);
    }
}
