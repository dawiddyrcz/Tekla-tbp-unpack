using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBPUnpack
{
    internal class TBPUnpack
    {
        public TBPUnpack()
        {

        }

        public void Unpack(string inputPath, string outputPath)
        {
            if (File.Exists(inputPath).Equals(false))
                throw new FileNotFoundException();

            if (Directory.Exists(outputPath).Equals(false))
                Directory.CreateDirectory(outputPath);


        }
    }
}
