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
            try
            {
                UnZipToTmpDirectory();
                GetModelsNames();
                CopyModelsToOutputDirectory();
            }
            finally
            {
                if (Directory.Exists(tmpDir))
                    TryToDeleteDirectory(tmpDir);
            }
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

        private List<ModelFile> modelFiles = new List<ModelFile>();

        internal void GetModelsNames()
        {
            var filesWithModelFileDatas = GetFilesWithModelFileDatas();

            foreach (var filePath in filesWithModelFileDatas)
            {
                if (ModelFile.TryParse(filePath, out ModelFile modelFile))
                {
                    modelFiles.Add(modelFile);
                }
            }
        }

        internal void CopyModelsToOutputDirectory()
        {
            var mainDirs = Directory.GetDirectories(tmpDir);

            foreach (var mainDir in mainDirs)
            {
                foreach (var modelFile in modelFiles)
                {
                    var inputFileName = Path.Combine(mainDir, modelFile.Location);
                    var outputFileName = Path.Combine(outputPath, modelFile.Name);

                    try
                    {
                        File.Copy(inputFileName, outputFileName, true);
                    }
                    catch (Exception) { }
                }
            }
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

        internal List<string> GetFilesWithModelFileDatas()
        {
            var output = new List<string>();
            var mainDirs = Directory.GetDirectories(tmpDir);

            foreach (var mainDir in mainDirs)
            {
                var modelreferencesDirs = Path.Combine(mainDir, "modelreferences");
                output.AddRange(Directory.GetFiles(modelreferencesDirs));
            }

            return output;
        }
    }
}
