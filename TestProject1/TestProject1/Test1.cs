using ConsoleApp.Utilities;
using program;
using System.Diagnostics;

namespace TestProject1
{
    [TestClass]
    //*
    public sealed class Test1 : TestBase
    {
        private Program _program = null!;
        /*Sự khác nhau giữa 
                                private Calculator _cal = null!; và private Calculator? _cal = null; là gì ?
                    */
        public static TestContext TestContextInstance = null!;

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            //!  This method is called once for the test assembly, before any tests are run.

            TestContextInstance = context;
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            // This method is called once for the test assembly, after all tests are run.
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // This method is called once for the test class, after all tests of the class are run.
        }

        [TestInitialize]
        /* This method is called before each test method. 
                        Trước khi thực hiện mỗi phương thức kiểm tra [TestMethod], [TestInitialize] Sẽ khởi tạo những điều kiện, những biến cần thiết cho quá trình test*/
        public void TestInit()
        {

            /* Check file LogFilePath =  "test_log.txt" đã tồn tại hay chưa, nếu có rồi thì xóa nó */

            if (File.Exists(LogFilePath))
            {
                FileExtention.IsFileLocked(LogFilePath);
                File.Delete(LogFilePath);
            }
            /* Khởi tạo đối tượng Calculator */
            _program = new Program();
        }

        [TestMethod]
        /* Sau khi khởi tạo [TestInitialize], chúng ta sẽ tạo những Test case bằng cách đánh dấu bằng Attribute [TestMethod]
                            Chúng ta có thể thêm Attribute [Owner], [WorkItem] để biết được ai là người tạo test case này, và test case này thuộc WorkItem bao nhiêu
                            Việc tạo [WorkItem] sẽ thuận lợi cho việc chúng ta backtrade sau này 

                     * Chú ý: các phương thức được đánh dấu là [TestMethod] phải trả về kiểu void và không có tham số truyền vào

                    * Ngoài ra chúng ta có thể thêm [Priority] cho test case để đánh giá mức độ ưu tiên của chúng trong quá trình Kiểm thử (UNit Test)
                    * Chú ý : Cách đặt tên biến luôn phải phù hợp với mục đích của Test Case */
        [Owner("MAI TRUNG KIEN 14022025")]
        [Priority(1)]
        [WorkItem(112)]
        public void Test_Addition_BetweenNumber()
        {
            int result = _program.CalculatorAdd(10, 20);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        [Owner("MAI TRUNG KIEN Group by Student basedon Id")]
        [Priority(2)]
        [WorkItem(113)]
        [Timeout(240)] /* Setup thời gian tối đa cho testcase này là 1000ms, Nếu quá 1000ms thì test case sẽ FAILED */
        public void Test_TimeOut()
        {
            // This test will always fail because the time taken to execute is greater than the timeout value.
            _program.GroupByStudent();
        }
        [TestCleanup]
        /* Trong mỗi một class được đánh dấu là [TestClass] Attribute [TestCleanup] chỉ được khai báo 1 lần và trong [TestClass] có bao nhiêu
                    Attribute [TestMethod] thì [TestCleanup] sẽ được gọi bấy nhiêu lần*/
        public void TestCleanup()
        {
            /* This method is called after each test method. */
        }
    }
}
