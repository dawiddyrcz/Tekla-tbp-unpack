using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static ModelFile Deserialize(string inputFile)
        {
            var serializer = new XmlSerializer(typeof(ModelFile));
            return serializer.Deserialize(File.OpenRead(inputFile)) as ModelFile;
        }
    }
}
