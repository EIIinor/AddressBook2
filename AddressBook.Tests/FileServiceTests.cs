using AddressBook.Services;
using Newtonsoft.Json;

namespace AddressBook.Tests
{

    [TestClass]
    public class FileServiceTests
    {
        [TestMethod]
        public void Should_Create_File_With_JsonContent()
        {
            // arrange
            FileService fileService = new FileService();
            fileService.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}.\contentTest.json";
            string content = JsonConvert.SerializeObject(new { FirstName = "Test" });

            // act
            fileService.SaveToFile(content);
            string result = fileService.ReadFromFile();

            // assert
            Assert.IsTrue(File.Exists(fileService.FilePath));
            Assert.IsTrue(!string.IsNullOrEmpty(result));
        }
    }
}
