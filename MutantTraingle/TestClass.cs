using NUnit.Framework;
using NUnit.Framework.Legacy;
namespace Traingle1
{
    public class TestClass
    {
        //KULJEETSINGH
        [Test]
        public void TestTraingle()
        {
            float A = 50, B = 50, C = 90;
            int flag = 1;
            int result= Class1.TriangleIsosceles(A, B, C);
            ClassicAssert.AreEqual(flag, result);
        }
    }
}
