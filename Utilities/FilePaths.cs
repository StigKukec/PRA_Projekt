using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class FilePaths
    {
        private static readonly string direktorij = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName).Parent.FullName;

        public static string GetFilePath(string filePath)
        {
            string accountPath = Path.Join(direktorij, $@"{filePath}");
            return accountPath;
        }
    }
}
