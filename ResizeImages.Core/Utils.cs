using System;
using System.IO;

namespace ResizeImages.Core
{
    static public class Utils
    {
        public static bool DeleteDir(string path)
        {
            int repeat = 3;

            do
            {
                try
                {
                    if (Directory.Exists(path))
                        Directory.Delete(path, true);

                    return true;
                }
                catch (Exception ex)
                {
                    repeat--;
                    Console.WriteLine(ex.Message);
                }
            } while (repeat > 0);

            return false;
        }

        public static bool DeleteFile(string path)
        {
            int repeat = 3;

            do
            {
                try
                {
                    if (File.Exists(path))
                        File.Delete(path);

                    return true;
                }
                catch (Exception ex)
                {
                    repeat--;
                    Console.WriteLine(ex.Message);
                }
            } while (repeat > 0);

            return false;
        }
    }
}
