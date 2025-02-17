using ConsoleApp.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using program;

namespace TestProject1
{
    [TestClass]
    public class TestBase
    {
        public TestContext TestContext { get; set; }
        private Stopwatch _stopwatch =null!;

        public static readonly string LogFilePath = "test_log.txt";
        private static readonly object fileLock = new object();

        public EmailValidator _emailValidator = null!;

        public Program _program = null!;

        private void LogToFile(string message)
        {
            // Ghi log vào file, thêm dòng mới sau mỗi log
            lock (fileLock)
            {
                File.AppendAllText(LogFilePath, "----------------------------------------------------------------" 
                    + Environment.NewLine);
                File.AppendAllText(LogFilePath, message + Environment.NewLine);
            }
        }
       
        [TestInitialize]
        public void InitializeTest()
        {
            // Bắt đầu đo thời gian ngay trước khi test chạy
            _stopwatch = Stopwatch.StartNew();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            // Dừng đồng hồ và ghi log thời gian chạy
            _stopwatch.Stop();

            // or Trace.Listeners.Add(new ConsoleTraceListener());
            LogToFile($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Thời gian chạy của test {TestContext.TestName}: {_stopwatch.ElapsedMilliseconds} ms");

            //Trace.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Thời gian chạy của test {TestContext.TestName}: {_stopwatch.ElapsedMilliseconds} ms");
            TestContextInstance.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Thời gian chạy của test {TestContext.TestName}: {_stopwatch.ElapsedMilliseconds} ms");
        }

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
            TestContextInstance.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Calling AssemblyCleanup");
        }

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            TestContextInstance.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Calling ClassInit");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            // This method is called once for the test class, after all tests of the class are run.
            TestContextInstance.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Calling ClassCleanup");
        }
    }
}
