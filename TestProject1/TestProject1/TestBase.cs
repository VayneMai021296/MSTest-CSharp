using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class TestBase
    {
        public TestContext TestContext { get; set; }
        private Stopwatch _stopwatch =null!;

        public static readonly string LogFilePath = "test_log.txt";
        private static readonly object fileLock = new object();

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
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
        }

        [TestCleanup]
        public void CleanupTest()
        {
            // Dừng đồng hồ và ghi log thời gian chạy
            _stopwatch.Stop();

            // or Trace.Listeners.Add(new ConsoleTraceListener());
            LogToFile($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Thời gian chạy của test {TestContext.TestName}: {_stopwatch.ElapsedMilliseconds} ms");

            Trace.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}] Thời gian chạy của test {TestContext.TestName}: {_stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
