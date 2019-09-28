using System;
using System.IO;
using System.Xml.Serialization;

namespace TBPUnpack
{
    [Serializable]
    public class ModelFile
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public ModelFile()
        {

        }

        public static bool TryParse(string inputFile, out ModelFile modelFile)
        {
            try
            {
                modelFile = Deserialize(inputFile);
                return true;
            }
            catch (Exception)
            {
                modelFile = null;
                return false;
            }
        }

        public static ModelFile Deserialize(string inputFile)
        {
            var serializer = new XmlSerializer(typeof(ModelFile));
            return serializer.Deserialize(File.OpenRead(inputFile)) as ModelFile;
        }
    }
}
