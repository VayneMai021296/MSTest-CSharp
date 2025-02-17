using ConsoleApp.Utilities;
using program;
using System.Diagnostics;

namespace TestProject1
{
    [TestClass]
    //*
    public sealed class Test1 : TestBase
    {
        /*Sự khác nhau giữa 
                                private Calculator _cal = null!; và private Calculator? _cal = null; là gì ?
                    */

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
        /* Sau khi khởi tạo [TestInitialize], chúng ta sẽ tạo những Test case bằng cách đánh dấu bằng phương thức Attribute [TestMethod]
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
        [Timeout(240)] /* Setup thời gian tối đa cho testcase này là 1000ms, Nếu quá 1000ms thì test case sẽ FAILED */
        [Owner("MAI TRUNG KIEN Group by Student basedon Id")]
        [Priority(2)]
        [WorkItem(113)]
        public void Test_TimeOut()
        {
            // This test will always fail because the time taken to execute is greater than the timeout value.
            _program.GroupByStudent();
        }


        [TestMethod]
        [DataTestMethod]
        /* Đánh dấu một phương thức test là data-driven test (kiểm thử với nhiều bộ dữ liệu khác nhau).
                        * Cho phép chạy lại cùng một test method với nhiều giá trị đầu vào. */
        [DataRow(2, 3, 5)]
        [DataRow(4, 5, 9)]
        public void Add_DataDrivenTest(int a, int b, int expected)
        {
            int result = _program.CalculatorAdd(a, b);
            Assert.AreEqual(expected, result);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { 2, 3, 5 };
            yield return new object[] { 4, 5, 9 };
        }

        [TestMethod]
        [DataTestMethod]
        /*  Tương tự [DataRow] nhưng cho phép cung cấp dữ liệu từ một nguồn động (ví dụ: từ một phương thức hoặc thuộc tính trả về IEnumerable<object[]>). 
                    *  Giúp tạo dữ liệu kiểm thử linh hoạt và mở rộng.*/
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void Add_DynamicDataTest(int a, int b, int expected)
        {
            int result = _program.CalculatorAdd(a, b);
            Assert.AreEqual(expected, result);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        ///* Chỉ định rằng một test method dự kiến sẽ ném ra một loại exception nhất định. 
        //                * Nếu exception được ném ra như dự kiến  =>  test được coi là thành công; 
        //                * ngược lại => test sẽ thất bại.*/
        //public void Divide_ByZero_ThrowsArgumentException()
        //{
        //    // Giả sử hàm Divide ném ArgumentException khi chia cho 0
        //    _program.CalculatorDivece(10, 0);
        //}


        [TestCleanup]
        /* Trong mỗi một class được đánh dấu là [TestClass] Attribute [TestCleanup] chỉ được khai báo 1 lần duy nhât, và trong [TestClass] có bao nhiêu
                    Attribute [TestMethod] thì [TestCleanup] sẽ được gọi bấy nhiêu lần*/
        public void TestCleanup()
        {
            /* This method is called after each test method. */
        }
    }
}
