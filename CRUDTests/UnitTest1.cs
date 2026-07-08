namespace CRUDTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
MyMath1 m=new MyMath1();
            int input1 = 10,
                input2 = 5,
                expected=15;
        int actual=m.Add(input1, input2);
            Assert.Equal(expected, actual);
        }
    }
}
