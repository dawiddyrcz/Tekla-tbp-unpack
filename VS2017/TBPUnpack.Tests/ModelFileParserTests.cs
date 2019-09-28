using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBPUnpack.Tests
{
    class ModelFileParserTests
    {
        private string GetTestDir()
        {
            return Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
        }

        [Test]
        public void ParseModelFile1_ShouldParse()
        {
            var filePath = Path.Combine(GetTestDir(), "ModelFileXML1.txt");
            var modelFile = ModelFile.Deserialize(filePath);
            Assert.AreEqual("StpFile.stp", modelFile.Name);
            Assert.AreEqual("files/Models/845f3197-4722-4248-b160-c6451f18db52.stp", modelFile.Location);

        }

        [Test]
        public void ParseNotModelFile_ShouldNotParse()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var filePath = Path.Combine(GetTestDir(), "ModelGroupXML1.txt");
                var modelFile = ModelFile.Deserialize(filePath);
            });
        }
    }
}
