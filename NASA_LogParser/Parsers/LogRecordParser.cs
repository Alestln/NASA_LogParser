using System.Globalization;
using System.Text;
using NASA_LogParser.Entities;

namespace NASA_LogParser.Parsers;

public class LogRecordParser : ILogRecordParser
{
    public LogRecord Parse(string logRecord)
    {
        var recordData = logRecord.Split(' ');
        var ip = recordData[0];

        var builder = new StringBuilder();

        builder.Append(recordData[3]);
        builder.Append(' ');
        builder.Append(recordData[4]);
        builder.Remove(0, 1);
        builder.Remove(builder.Length - 1, 1);

        var date = DateTime.ParseExact(builder.ToString(), "dd/MM/yyyy:HH:mm:ss zzzz", CultureInfo.InvariantCulture);
        var method = recordData[5].TrimStart('"');
        var path = recordData[6];
        var protocol = recordData[7].TrimEnd('"');

        var statusCode = int.Parse(recordData[8]);
        var size = int.Parse(recordData[9]);

        return new LogRecord(ip, date, method, path, protocol, statusCode, size);
    }
}