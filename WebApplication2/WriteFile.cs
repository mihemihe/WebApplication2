namespace WebApplication2
{
    public static class WriteFile
    {
        // add a new method to write a file using streamwriter and using
        public static void WriteToFile()
        {
            string filePath = "c:\\folderdontexist\\thisfiledoesnotexist.txt";
            using (StreamWriter sw = File.AppendText(filePath)) { sw.WriteLine("this is a literal string to write on the file"); }
        }

        


    }
}
