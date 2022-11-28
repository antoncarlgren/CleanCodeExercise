using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteGenerator.DataReader
{
    class FileReader : IDataReader
    {
        string IDataReader.GetString(string source)
        {
            if(File.Exists(source))
            {
                return File.ReadAllText(source);
            }
            else
            {
                File.WriteAllText(source, "blue");
            }
        }

        IEnumerable<string> IDataReader.GetStringArray(string source)
        {
            throw new NotImplementedException();
        }
    }
}
