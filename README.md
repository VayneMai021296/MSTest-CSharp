# MSTest-CSharp

# About MSTest-CSharp
MSTest-CSharp is a testing framework for C# that is part of the .NET Core framework. It is a unit testing framework that allows you to write and run tests for your code.
## MSTest Attributes and Their Usage

Here are the main attributes used in MSTest with explanations and examples:

### 1. [TestClass]
- **Purpose**: Marks a class that contains test methods
- **Usage**: Must be applied to any class containing test methods
    - **Example**:
    ```csharp
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]    
        public void TestMethod1()
        {
            // Test code here
        }
    }
    ``` 
    - **Explanation**:
    - The `[TestClass]` attribute is applied to the `CalculatorTests` class.
    - This tells MSTest that this class contains test methods.
    - The class must contain at least one test method.  

### 2. [TestMethod]
- **Purpose**: Marks a method as a test method
- **Usage**: Applied to individual test methods within a TestClass
    - **Example**:
    ```csharp
    [TestMethod]
    public void TestMethod1()
    {
        // Test code here
    }   
    ```
    - **Explanation**:
    - The `[TestMethod]` attribute is applied to the `TestMethod1` method.
    - This tells MSTest that this method is a test method.
    - The method must be a member of a TestClass.

### 3. [TestInitialize]
- **Purpose**: Marks a method to be called before each test
- **Usage**: Used to set up the test environment
    - **Example**:
    ```csharp
    private string _testName;
    [TestInitialize]
    public void TestInitialize()
    {
        // Test initialization code here 
        _testName = "This is initialization";
    }           
    ```
    - **Explanation**:
    - The `[TestInitialize]` attribute is applied to the `TestInitialize` method.
    - This tells MSTest that this method is called before each test.
    - The method must be a member of a TestClass.

### 4. [TestCleanup]
- **Purpose**: Marks a method to be called after each test
- **Usage**: Used to clean up the test environment      
    - **Example**:
    ```csharp
    [TestCleanup]
    public void TestCleanup()
    {
        // Test cleanup code here
    }   
    ```
    - **Explanation**:
    - The `[TestCleanup]` attribute is applied to the `TestCleanup` method.
    - This tells MSTest that this method is called after each test.
    - The method must be a member of a TestClass.

### 5. [TestCategory]
- **Purpose**: Used to categorize tests
- **Usage**: Applied to test methods to group them
    - **Example**:
    ```csharp
    [TestCategory("CategoryName")]
    public void TestMethod1()
    {
        // Test code here
    }
    ```     
    - **Explanation**:
    - The `[TestCategory("CategoryName")]` attribute is applied to the `TestMethod1` method.
    - This tells MSTest that this method belongs to the "CategoryName" category.
    - The method must be a member of a TestClass.

### 6. [TestProperty]
- **Purpose**: Used to add custom properties to tests
- **Usage**: Applied to test methods to add metadata
    - **Example**:
    ```csharp
    [TestProperty("PropertyKey", "PropertyValue")]
    public void TestMethod1()
    {
        // Test code here
    }   
    ```
    - **Explanation**:
    - The `[TestProperty("PropertyKey", "PropertyValue")]` attribute is applied to the `TestMethod1` method.
    - This tells MSTest that this method has the "PropertyKey" property with the value "PropertyValue".
    - The method must be a member of a TestClass.

### 7. [TestTimeout]
- **Purpose**: Sets a timeout for a test
- **Usage**: Applied to test methods to set a maximum execution time
    - **Example**:
    ```csharp
    [TestTimeout(1000)]
    public void TestMethod1()
    {
        // Test code here
    }   
    ```
    - **Explanation**:
    - The `[TestTimeout(1000)]` attribute is applied to the `TestMethod1` method.
    - This tells MSTest that this method should not exceed 1000 milliseconds.
    - The method must be a member of a TestClass.

### 8. [TestInitializeAttribute]
- **Purpose**: Marks a method to be called before each test
- **Usage**: Used to set up the test environment
    - **Example**:
    ```csharp
    [TestInitializeAttribute]
    public void TestInitialize()
    {
        // Test initialization code here
    }
    ``` 
    - **Explanation**:
    - The `[TestInitializeAttribute]` attribute is applied to the `TestInitialize` method.
    - This tells MSTest that this method is called before each test.
    - The method must be a member of a TestClass.

### 9. [TestCleanupAttribute]
- **Purpose**: Marks a method to be called after each test
- **Usage**: Used to clean up the test environment
    - **Example**:
    ```csharp
    [TestCleanupAttribute]
    public void TestCleanup()
    {
        // Test cleanup code here
    }
    ``` 
    - **Explanation**:
    - The `[TestCleanupAttribute]` attribute is applied to the `TestCleanup` method.
    - This tells MSTest that this method is called after each test.
    - The method must be a member of a TestClass.

### 10. [TestClassAttribute]
- **Purpose**: Marks a class that contains test methods
- **Usage**: Applied to test methods to group them
    - **Example**:
    ```csharp
    [TestClassAttribute]
    public class CalculatorTests
    {
        // Test code here
    }   
    ```
    - **Explanation**:
    - The `[TestClassAttribute]` attribute is applied to the `CalculatorTests` class.
    - This tells MSTest that this class contains test methods.
    - The class must contain at least one test method.

### 12. [TestPropertyAttribute]
- **Purpose**: Used to add custom properties to tests
- **Usage**: Applied to test methods to add metadata
    - **Example**:
    ```csharp
    [TestPropertyAttribute("PropertyKey", "PropertyValue")]
    public void TestMethod1()
    {
       
    }   
    ```
    - **Explanation**:
    - The `[TestPropertyAttribute("PropertyKey", "PropertyValue")]` attribute is applied to the `TestMethod1` method.
    - This tells MSTest that this method has the "PropertyKey" property with the value "PropertyValue".
    - The method must be a member of a TestClass.

### 13. [TestTimeoutAttribute]
- **Purpose**: Sets a timeout for a test
- **Usage**: Applied to test methods to set a maximum execution time    
    - **Example**:
    ```csharp
    [TestTimeout(1000)]
    public void TestMethod1()
    {
        // Test code here
    }   
    ```
    - **Explanation**:
    - The `[TestTimeoutAttribute(1000)]` attribute is applied to the `TestMethod1` method.
    - This tells MSTest that this method should not exceed 1000 milliseconds.
    - The method must be a member of a TestClass.

### 14. [TestInitializeAttribute]
- **Purpose**: Marks a method to be called before each test
- **Usage**: Used to set up the test environment
- **Example**:
    ```csharp
    [TestInitializeAttribute]
    public void TestInitialize()
    {
        // Test initialization code here
    } 
    ```
    - **Explanation**:
    - The `[TestInitializeAttribute]` attribute is applied to the `TestInitialize` method.
    - This tells MSTest that this method is called before each test.
    - The method must be a member of a TestClass.

### 15. [TestCleanupAttribute]
- **Purpose**: Marks a method to be called after each test  
- **Usage**: Used to clean up the test environment
    - **Example**:
    ```csharp
    [TestCleanupAttribute]
    public void TestCleanup()
    {
        // Test cleanup code here
    }   
    ```
    - **Explanation**:
    - The `[TestCleanupAttribute]` attribute is applied to the `TestCleanup` method.
    - This tells MSTest that this method is called after each test.
    - The method must be a member of a TestClass.

### 16. [AssemblyInitialize]
- **Purpose**: Marks a method to be called once before any tests in the assembly are run
- **Usage**: Used for one-time setup across all test classes in an assembly
    - **Example**:
    ```csharp
    [AssemblyInitialize]
    public void AssemblyInitialize()
    {
        // Assembly initialization code here
    }   
    ```     
    - **Explanation**:  
    - The `[AssemblyInitialize]` attribute is applied to the `AssemblyInitialize` method.
    - This tells MSTest that this method is called once before any tests in the assembly are run.
    - The method must be a member of a TestClass.

### 17. [AssemblyCleanup] 
- **Purpose**: Marks a method to be called once after all tests in the assembly have completed
- **Usage**: Used for one-time cleanup across all test classes in an assembly
    - **Example**:  
    ```csharp
    [AssemblyCleanup]
    public void AssemblyCleanup()
    {
        // Cleanup code here
    }    
    ```
    - **Explanation**:
    - The `[AssemblyCleanup]` attribute is applied to the `AssemblyCleanup` method.
    - This tells MSTest that this method is called once after all tests in the assembly have completed.
    - The method must be a member of a TestClass.

### 18. [ClassInitialize]
- **Purpose**: Marks a method to be called once before any tests in a test class are run
- **Usage**: Used for one-time setup at the class level
- **Example**:
    ```csharp
    [ClassInitialize]
    public void ClassInitialize()
    {
        // Setup code here
    }   
    ``` 
    - **Explanation**:
    - The `[ClassInitialize]` attribute is applied to the `ClassInitialize` method.
    - This tells MSTest that this method is called once before any tests in a test class are run.
    - The method must be a member of a TestClass.

### 19. [ClassCleanup]
- **Purpose**: Marks a method to be called once after all tests in a test class have completed
- **Usage**: Used for one-time cleanup at the class level
- **Example**:
    ```csharp
    [ClassCleanup]
    public void ClassCleanup()
    {
        // Cleanup code here
    }   
    ```
    - **Explanation**:
    - The `[ClassCleanup]` attribute is applied to the `ClassCleanup` method.
    - This tells MSTest that this method is called once after all tests in a test class have completed.
    - The method must be a member of a TestClass.

### 20. [Owner]
- **Purpose**: Specifies the owner of a test
- **Usage**: Used to identify who is responsible for maintaining the test
- **Example**:
    ```csharp
    [Owner("JohnDoe")]
    public void TestMethod_Owner()
    {
        // Test code here
    }   
    ```
    - **Explanation**:
    - The `[Owner("JohnDoe")]` attribute is applied to the `TestMethod_Owner` method.
    - This tells MSTest that this method is owned by "JohnDoe".
    - The method must be a member of a TestClass.

### 21. [Priority]
- **Purpose**: Assigns a priority level to a test
- **Usage**: Used to determine the order of test execution
- **Example**:
    ```csharp
    [Priority(1)]
    public void TestMethod_Priority()
    {
        // Test code here
    }    
    ```
    - **Explanation**:
    - The `[Priority(1)]` attribute is applied to the `TestMethod_Priority` method.
    - This tells MSTest that this method has a priority level of 1.
    - The method must be a member of a TestClass.

### 22. [WorkItem]
- **Purpose**: Associates a test with a work item or bug
- **Usage**: Used to link tests with tracking items
- **Example**:
    ```csharp
    [WorkItem("12345")]
    public void TestMethod_WorkItem()
    {
        // Test code here
    }   
    ```
    - **Explanation**:
    - The `[WorkItem("12345")]` attribute is applied to the `TestMethod_WorkItem` method.
    - This tells MSTest that this method is associated with the work item "12345".
    - The method must be a member of a TestClass.

### 23. [DeploymentItem]
- **Purpose**: Specifies files to be copied to the test deployment directory
- **Usage**: Used when tests need access to external files

### 24. [DataSource]
- **Purpose**: Specifies an external data source for data-driven tests
- **Usage**: Used to connect tests with external test data
- **Example**:
```csharp
[DataSource("MyDataSource", "MyDataProvider", "SELECT * FROM MyTable")]
public void TestMethod_DataSource()
{
    // Test code here
}   
```
- **Explanation**:
- The `[DataSource("MyDataSource", "MyDataProvider", "SELECT * FROM MyTable")]` attribute is applied to the `TestMethod_DataSource` method.
- This tells MSTest that this method uses the "MyDataSource" data source with the "MyDataProvider" provider and the query "SELECT * FROM MyTable".
- The method must be a member of a TestClass.

### 25. [ExpectedException]
- **Purpose**: Specifies that a test method is expected to throw an exception
- **Usage**: Used for testing error conditions and exception handling
- **Example**:
```csharp
[ExpectedException(typeof(ArgumentException))]
public void TestMethod_ExpectedException()
{
    Calculator calc = new Calculator();
    calc.Divide(10, 0);
}
```
# How to create TestBase Class to apply configuration for all test methods, after finish test logfile to file test_log.txt

```csharp
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
        LogToFile($"[{DateTime.Now}] Thời gian chạy của test {TestContext.TestName}: {_stopwatch.ElapsedMilliseconds} ms");
        Trace.WriteLine($"Thời gian chạy của test {TestContext.TestName}: {_stopwatch.ElapsedMilliseconds} ms");
    }
}
```
* Implement TestBase Class to TestClass
```csharp
[TestClass]
public class TestBase : TestBase
{
    public void TestInit()
    {
        /* Check file LogFilePath =  "test_log.txt" đã tồn tại hay chưa, nếu có rồi thì xóa nó */
        if (File.Exists(LogFilePath))
        {
            File.Delete(LogFilePath);
        }
    }
    [TestMethod]
    public void TestMethod1()
    {
        // Test code here
    }
    [TestMethod]
    public void TestMethod2()
    {
        // Test code here
    }
}
```

# Chú ý
- Khi chạy test trên Linux hoặc macOS, cần chạy lệnh sau để tạo file log:
```bash
dotnet test --logger "console;verbosity=detailed"
```
- Khi chạy test trên Windows, cần chạy lệnh sau để tạo file log:
```bash
dotnet test --logger "console;verbosity=detailed"
```
- Những method nào được đánh dấu Attribute là `[TestMethod]` thì sau khi chạy sau mới gọi được method được đánh dấu Attribute là `[TestCleanup]`
- Method được đánh giấu là  `[AssemblyInitialize]` hoặc `[ClassInitialize]` thì chỉ chạy 1 lần duy nhất trước khi chạy các test method, 
Những method này có kiểu là static và có tham số là TestContext, chúng ta sẽ sử dụng biến này để lấy tên test method, tên test class, tên assembly, tên project, tên solution, tên máy tính, tên người dùng, thời gian chạy test, và các thông tin khác.
```css 
Thông tin của TestContext
|
├── TestName: Tên của test method
├── TestContext.TestName: Tên của test method
├── TestContext.TestClass: Tên của test class
├── TestContext.TestAssembly: Tên của test assembly
├── TestContext.TestProject: Tên của test project
├── TestContext.TestSolution: Tên của test solution
├── TestContext.TestResultsDirectory: Đường dẫn thư mục kết quả test
├── TestContext.TestRunDirectory: Đường dẫn thư mục kết quả test run
├── TestContext.TestRunResultsDirectory: Đường dẫn thư mục kết quả test run results
...
```

# How to build solution Test and Project (Linux or macOS)

* **Step1: Open Terminal or Command Prompt and run the following command to create a solution:**

```bash 
dotnet new sln -n MySolution
```
* **Step2: Create main Project(Console App)**

```bash
dotnet new console -n MyConsoleApp
```

- This command will create a MyConsoleApp directory containing the console project with Program.cs file.
- Add the Console App project to the solution:

```bash
dotnet sln MySolution.sln add MyConsoleApp/MyConsoleApp.csproj
```

* **Step3: Create Test Project**

```bash
dotnet new mstest -n MyConsoleApp.Tests
```
After add project test, add project test to solution:

```bash
dotnet sln MySolution.sln add MyConsoleApp.Tests/MyConsoleApp.Tests.csproj
```
* **Step4: Add reference from Test Project to Main Project**

```bash
dotnet add MyConsoleApp.Tests/MyConsoleApp.Tests.csproj reference MyConsoleApp/MyConsoleApp.csproj
```

* **Step5: Run the tests**
** Build the solution
```bash
dotnet build
```
* **Run the tests**
```bash
dotnet test
```

**Summary the Architecture of Project**
```css 
Step to Structure Project
|
├── Step1: Create Solution
│   ├── dotnet new sln -n MySolution

├── Step2: Create Main Project
│   ├── dotnet new console -n MyConsoleApp

├── Step3: Create Test Project
│   ├── dotnet new mstest -n MyConsoleApp.Tests
│   ├── dotnet sln MySolution.sln add MyConsoleApp.Tests/MyConsoleApp.Tests.csproj

├── Step4: Add reference from Test Project to Main Project
│   ├── dotnet add MyConsoleApp.Tests/MyConsoleApp.Tests.csproj reference MyConsoleApp/MyConsoleApp.csproj

├── Step5: Run the tests
│   ├── dotnet build
│   ├── dotnet test
```
```css 
MySolution/
|── MySolution.sln
├── MyConsoleApp/
│   ├── MyConsoleApp.csproj
│   └── Program.cs
└── MyConsoleApp.Tests/
    ├── MyConsoleApp.Tests.csproj
    └── UnitTest1.cs  (test name depend on you)
```
# How to install .NET SDK on Ubuntu (macOS)
```bash
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y apt-transport-https
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0 # Version 8.0 [Version depend on you]
```

# How to install MSTest-CSharp on Ubuntu (macOS)
```bash
dotnet add package MSTest.TestAdapter
dotnet add package MSTest.TestFramework
dotnet add package Microsoft.NET.Test.Sdk
```
# How to run test on Ubuntu (macOS)
Sau khi chạy lệnh dotnet build, output của dự án (bao gồm file .exe) thường được tạo ra trong thư mục con như:

Với chế độ Debug: bin/Debug/<framework>/
Với chế độ Release: bin/Release/<framework>/
Ví dụ, nếu bạn build dự án .NET Core hoặc .NET 5/6/7 với target framework là net6.0, file .exe (nếu dự án được build dưới dạng self-contained trên Windows) sẽ nằm ở:

```python
Copy
bin\Debug\net6.0\MyApp.exe
```
Để chạy file .exe bằng terminal:

- 1. Mở Command Prompt hoặc PowerShell (trên Windows).

- 2. Điều hướng đến thư mục chứa file .exe. Ví dụ:

```bash
Copy
cd bin\Debug\net6.0
```
Chạy file .exe:

```bash
.\MyApp.exe
```
(Ở PowerShell bạn cần thêm dấu .\ để chạy file thực thi trong thư mục hiện tại.)

**``Lưu ý:``**

* Nếu dự án của bạn không được build dưới dạng self-contained, thay vào đó bạn chỉ có file .dll, bạn cần chạy:

```bash
dotnet MyApp.dll
```
Trên các hệ điều hành Linux hoặc macOS, file .exe không chạy trực tiếp. Nếu bạn cần chạy ứng dụng trên Linux/macOS, bạn có thể build ứng dụng dưới dạng framework-dependent (sẽ tạo ra file .dll) và chạy bằng lệnh:

```bash
dotnet MyApp.dll
```
Hoặc bạn có thể build ứng dụng dưới dạng self-contained cho Linux/macOS để có file thực thi riêng (không cần dotnet), nhưng tên file sẽ không có đuôi .exe.

Tóm lại, để chạy file .exe trên Windows sau khi build, bạn chỉ cần điều hướng đến thư mục output và gõ tên file (hoặc dùng .\ trên PowerShell/Command Prompt) để chạy ứng dụng.

# MSTest Filtering by TestCategory

Trong quá trình phát triển với MSTest, bạn có thể chỉ chạy các test method có thuộc tính `[TestCategory]` cụ thể. Việc này rất hữu ích khi bạn muốn tập trung chạy một nhóm test nào đó (ví dụ: các test tích hợp, smoke test, …) mà không cần chạy toàn bộ bộ test.

## 1. Sử dụng `dotnet test`

Nếu bạn dùng .NET Core/5/6/7, bạn có thể sử dụng lệnh `dotnet test` kèm với bộ lọc (filter) để chỉ chạy các test có thuộc tính `[TestCategory]` nhất định.

**Ví dụ:**
- Để chạy chỉ các test có `[TestCategory("Integration")]`:
```bash
dotnet test --filter "TestCategory=Integration"
dotnet test --filter "TestCategory=Integration|TestCategory=Smoke"
dotnet test --filter "TestCategory!=Slow"
```










