// public class Marcello
// {
//     public void getMarcello(){
//         Console.WriteLine("Mi chiamo Marcello");
//         getMarcello();
//     }
// }

using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        String[] logLine1 = logLine.Split(":");
        return logLine1[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        String[] logLine1 = logLine.Split(":");
        String logLine2 = logLine1[0]; 
        String result = logLine2.Substring(1,logLine2.Length -2);
        return result.ToLower();
    }

    public static string Reformat(string logLine)
    {
        String str_message = LogLine.Message(logLine);
        String str_loglevel= LogLine.LogLevel(logLine);
        String result = str_message + " (" + str_loglevel + ")";
        return result;
    }
}
