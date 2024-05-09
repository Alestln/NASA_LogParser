namespace NASA_LogParser.Providers;

public interface ILogProvider
{
    Task<string?> GetLogRecord(CancellationToken cancellationToken = default);
}