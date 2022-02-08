using NUnit.Framework;
using StunningBarnacle.AzureDirectoryTransfer;

namespace Tests
{
    public class TestRecursiveDirectoryUploadTool
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConstructor()
        {
            new RecursiveDirectoryUploadTool();
        }
    }
}
