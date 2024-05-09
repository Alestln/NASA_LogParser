namespace NASA_LogParser.Providers;

public class LogProvider(StreamReader streamReader) : ILogProvider
{
    public async Task<string?> GetLogRecord(CancellationToken cancellationToken = default)
    {
        return await streamReader.ReadLineAsync(cancellationToken);
    }
}