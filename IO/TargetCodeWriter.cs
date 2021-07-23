using Compiler.CodeGeneration;
using System;
using System.IO;

namespace Compiler.IO
{
   
    public class TargetCodeWriter
    {
        
        public string BinaryOutputFile { get; }

        
        public string TextOutputFile { get; }

       
        public ErrorReporter Reporter { get; }

       
        public TargetCodeWriter(string binaryOutputFile, string textOutputFile, ErrorReporter reporter)
        {
            BinaryOutputFile = binaryOutputFile;
            TextOutputFile = textOutputFile;
            Reporter = reporter;
        }

        
        public void WriteToFiles(TargetCode targetCode)
        {
            try
            {
                File.WriteAllBytes(BinaryOutputFile, targetCode.ToBinary());
            }
            catch (Exception ex)
            {
                // Error: Problem writing binary output file
            }
            try
            {
                File.WriteAllText(TextOutputFile, targetCode.ToString());
            }
            catch (Exception ex)
            {
                // Error: Problem writing text output file
            }
        }
    }
}