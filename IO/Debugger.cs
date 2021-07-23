using System;
namespace Compiler.IO
{

	public static class Debugger
	{
		private const bool DEBUG = false;

		public static void Write(string message)
		{
			if (DEBUG)
#pragma warning disable CS0162 // Unreachable code detected
                Console.WriteLine($"DEBUGGING INFO: {message}");
#pragma warning restore CS0162 // Unreachable code detected
        }
	}
}