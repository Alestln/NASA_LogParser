namespace NASA_LogParser;

class Program
{
    static async Task Main(string[] args)
    {
        CancellationTokenSource source = new CancellationTokenSource(); 
        
        string path = @"/home/reptiloid/RiderProjects/NASA_LogParser/NASA_LogParser/Logs/access_log_Jul95";
        await using var stream = new FileStream(path, FileMode.Open);

        
    }
}