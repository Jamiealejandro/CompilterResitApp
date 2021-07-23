using static System.Console;

namespace Compiler.IO
{

    public class ErrorReporter
    {
        public int ErrorCount { get; private set; } = 0;

        public bool HasErrors { get { return ErrorCount > 0; } }

        public static void ReportError(int ErrorCount, string message)
        {
            ErrorCount += 1;
            WriteLine($"ERROR: {message}");
        }
    }
}

   
