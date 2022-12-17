


namespace WebApplication2
{
    public class BackgroundTask : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Task.Run(async () =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine("\r\n---Before writing to file");
                    
                    WriteFile.WriteToFile();
                    
                    Console.WriteLine("\r\n---After writing to file");


                    int seconds = 5;
                    Console.WriteLine("\r\n--------- END ------------------ | Waiting {0} seconds", seconds);
                    await Task.Delay(new TimeSpan(0, 0, seconds)); // 5 second delay
                }
            });

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}