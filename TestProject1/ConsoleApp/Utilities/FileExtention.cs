using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Utilities
{
    public static class FileExtention
    {
        public static bool IsFileLocked(string filePath)
        {
            FileStream stream = null!;

            try
            {
                stream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                /*  Nếu bắt được IOException, có khả năng file đang được sử dụng */
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            /* Nếu mở file thành công, file không bị khóa */
            return false;
        }
    }
}
