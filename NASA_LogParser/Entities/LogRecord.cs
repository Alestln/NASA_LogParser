namespace NASA_LogParser.Entities;

public record LogRecord(
    string Ip, 
    DateTime Date,
    string Method,
    string Path,
    string Protocol,
    int StatusCode,
    int Size
    );