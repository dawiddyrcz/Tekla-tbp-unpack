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
            try
            {
                if (Directory.Exists(outputPath).Equals(false))
                    Directory.CreateDirectory(outputPath);

                UnpackTBP();
            }
            finally
            {
                if (Directory.Exists(tmpDir))
                    TryToDeleteDirectory(tmpDir);
            }
        }

        internal void UnpackTBP()
        {
            UnZipToTmpDirectory();
            GetModelsNames();
            CopyModelsToOutputDirectory();
            DeleteTmpDirectory();
        }

        private string tmpDir = string.Empty;

        internal void UnZipToTmpDirectory()
        {
        AGAIN:
            tmpDir = Path.Combine(outputPath, "tmp_" + Guid.NewGuid().ToString());
            if (Directory.Exists(tmpDir)) goto AGAIN;
            Directory.CreateDirectory(tmpDir);

            System.IO.Compression.ZipFile.ExtractToDirectory(inputPath, tmpDir);
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

        internal void TryToDeleteDirectory(string dirPath)
        {
            try
            {
                foreach (var dir in Directory.GetDirectories(dirPath))
                {
                    TryToDeleteDirectory(dir);
                }

                foreach (var file in Directory.GetFiles(dirPath))
                {
                    File.Delete(file);
                }

                Directory.Delete(dirPath);
            }
            catch (Exception) { }
        }
    }
}
