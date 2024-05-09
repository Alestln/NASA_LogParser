using NASA_LogParser.Entities;

namespace NASA_LogParser.Parsers;

public interface ILogRecordParser
{
    LogRecord Parse(string logRecord);
}