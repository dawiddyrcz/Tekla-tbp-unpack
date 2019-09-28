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
        private readonly string inputPath;
        private readonly string outputPath;

        public TBPUnpack(string inputPath, string outputPath)
        {
            if (inputPath is null) throw new NullReferenceException("inputPath");
            if (outputPath is null) throw new NullReferenceException("outputPath");

            if (File.Exists(inputPath).Equals(false))
                throw new FileNotFoundException();

            this.inputPath = inputPath;
            this.outputPath = outputPath;
        }

        public void Unpack()
        {
            if (Directory.Exists(outputPath).Equals(false))
                Directory.CreateDirectory(outputPath);

            UnpackTBP();
        }

        internal void UnpackTBP()
        {
            UnZipToTmpDirectory();
            GetModelsNames();
            CopyModelsToOutputDirectory();
            DeleteTmpDirectory();
        }

        internal void UnZipToTmpDirectory()
        {
            throw new NotImplementedException();
        }

        internal void GetModelsNames()
        {
            throw new NotImplementedException();
        }

        internal void CopyModelsToOutputDirectory()
        {
            throw new NotImplementedException();
        }

        internal void DeleteTmpDirectory()
        {
            throw new NotImplementedException();
        }
    }
}
