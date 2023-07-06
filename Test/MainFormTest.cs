using Common;

namespace Test
{
    public class MainFormTest
    {
        [Fact]
        public void TestGetValidUri_Valid()
        {
            var rawUrl = "https://www.google.com/";

            var result = Service.GetValidUri(rawUrl);

            Assert.Equal(rawUrl, result.ToString());
        }

        [Fact]
        public void TestGetValidUri_Incomplete()
        {
            var rawUrl = "google.com/";

            var result = Service.GetValidUri(rawUrl);

            Assert.Equal("https://google.com/", result.ToString());
        }

        [Fact]
        public void TestGetValidUri_Query()
        {
            var rawUrl = "google";

            var result = Service.GetValidUri(rawUrl);

            Assert.Equal("https://google.com/search?q=google", result.ToString());
        }
    }
}