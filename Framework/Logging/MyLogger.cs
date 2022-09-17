namespace Framework.Logging
{
    public class MyLogger
    {
        private readonly string _filePath;

        public MyLogger(string testName, string filePath)
        {
            _filePath = filePath;

            using(var log = File.CreateText(_filePath))
            {
                log.WriteLine($"Staring Time: {DateTime.Now.ToLocalTime()}");
                log.WriteLine($"Test: {testName}");
                log.WriteLine("__________________________________________________________");
            }
        }

        public void Info(string message)
        {
            WriteLine($"[INFO]: {message}");
        }

        public void Step(string message)
        {
            WriteLine($"    [STEP]: {message}");
        }

        public void Warning(string message)
        {
            WriteLine($"[WARNING]: {message}");
        }

        public void Error(string message)
        {
            WriteLine($"[Error]: {message}");
        }

        public void Fatal(string message)
        {
            WriteLine($"[FATAL]: {message}");
        }

        private void WriteLine(string text)
        {
            using(var log = File.AppendText(_filePath))
            {
                log.WriteLine(text);
            }
        }

        private void Write(string text)
        {
            using (var log = File.AppendText(_filePath))
            {
                log.Write(text);
            }
        }
    }
}
