namespace TestsProj
{
    [TestClass]
    public class AsdaTitleTest
    {
        private string _filePath = @"C:\Users\josealonso\Source\Repos\zaracheema\devops--best-practice\Pages\Index.cshtml";

        [TestMethod]
        public void TestIndexHasAsdaInTitle()
        {
            // Arrange
            string fileContent = File.ReadAllText(_filePath);

            // Act
            bool containsAsda = fileContent.Contains("Asda");

            // Assert
            Assert.IsTrue(containsAsda, "Error: 'Asda' is not part of the Title in Index.cshtml");
        }
    }
}