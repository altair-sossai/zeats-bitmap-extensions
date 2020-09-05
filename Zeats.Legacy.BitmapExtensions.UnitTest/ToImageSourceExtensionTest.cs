using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Legacy.BitmapExtensions.UnitTest
{
    [TestClass]
    public class ToImageSourceExtensionTest
    {
        [TestMethod]
        public void ToImageSource()
        {
            var bitmap = new Bitmap(100, 100);
            var imageSource = bitmap.ToImageSource();

            Assert.IsNotNull(imageSource);
        }
    }
}