//Copyright © Dawid Dyrcz 2019 see LICENSE file
using NUnit.Framework;
using System;
using System.IO;

namespace TBPUnpack.Tests
{
    class ModelFileParserTests
    {
        private string GetTestDir()
        {
            return Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
        }

        [Test]
        public void ParseModelFile1_Deserialize_ShouldParse()
        {
            var filePath = Path.Combine(GetTestDir(), "ModelFileXML1.txt");
            var modelFile = ModelFile.Deserialize(filePath);
            Assert.AreEqual("StpFile.stp", modelFile.Name);
            Assert.AreEqual("files/Models/845f3197-4722-4248-b160-c6451f18db52.stp", modelFile.Location);
        }

        [Test]
        public void ParseModelFile1_TryParse_ShouldParse()
        {
            var filePath = Path.Combine(GetTestDir(), "ModelFileXML1.txt");
            var result = ModelFile.TryParse(filePath, out ModelFile modelFile);
            Assert.IsTrue(result);
            Assert.AreEqual("StpFile.stp", modelFile.Name);
            Assert.AreEqual("files/Models/845f3197-4722-4248-b160-c6451f18db52.stp", modelFile.Location);
        }

        [Test]
        public void ParseModelFile2_Deserialize_ShouldParse()
        {
            var filePath = Path.Combine(GetTestDir(), "ModelFileXML2.txt");
            var modelFile = ModelFile.Deserialize(filePath);
            Assert.AreEqual("IFCZIPModel.ifcZIP", modelFile.Name);
            Assert.AreEqual("files/Models/0eafb97a-621b-4565-9e2f-c78ab2c0c5f9.ifcZIP", modelFile.Location);
        }

        [Test]
        public void ParseModelFile2_TryParse_ShouldParse()
        {
            var filePath = Path.Combine(GetTestDir(), "ModelFileXML2.txt");
            var result = ModelFile.TryParse(filePath, out ModelFile modelFile);
            Assert.IsTrue(result);
            Assert.AreEqual("IFCZIPModel.ifcZIP", modelFile.Name);
            Assert.AreEqual("files/Models/0eafb97a-621b-4565-9e2f-c78ab2c0c5f9.ifcZIP", modelFile.Location);
        }

        [Test]
        public void ParseNotModelFile1_Deserialize_ShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var filePath = Path.Combine(GetTestDir(), "ModelGroupXML1.txt");
                var modelFile = ModelFile.Deserialize(filePath);
            });
        }

        [Test]
        public void ParseNotModelFile1_TryParse_ShouldThrowException()
        {
            var filePath = Path.Combine(GetTestDir(), "ModelGroupXML1.txt");
            var result = ModelFile.TryParse(filePath, out ModelFile modelFile);
            Assert.IsFalse(result);
        }

        [Test]
        public void ParseNotModelFile2_Deserialize_ShouldThrowException()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var filePath = Path.Combine(GetTestDir(), "LinkXML1.txt");
                var modelFile = ModelFile.Deserialize(filePath);
            });
        }

        [Test]
        public void ParseNotModelFile2_TryParse_ShouldThrowException()
        {
            var filePath = Path.Combine(GetTestDir(), "LinkXML1.txt");
            var result = ModelFile.TryParse(filePath, out ModelFile modelFile);
            Assert.IsFalse(result);
        }
    }
}
