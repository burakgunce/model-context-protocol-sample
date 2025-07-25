using ModelContextProtocol.Server;
using Serilog;
using System.ComponentModel;

namespace MCP.Server.Tools
{
    [McpServerToolType]
    public static class EchoTool
    {
        [McpServerTool, Description("Girilen metni geri döndürür...")]
        public static string Echo(string message)
        {
            Log.Information("Echo tool'u çalıştırılıyor...");

            return $"Yankı : {message}";
        }
    }
}