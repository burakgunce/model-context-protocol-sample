using ModelContextProtocol.Server;
using Serilog;
using System.ComponentModel;

namespace MCP.Server.Tools
{
    [McpServerToolType]
    public static class CalculatorTool
    {
        [McpServerTool, Description("İki sayının toplamını döndürür...")]
        public static int Sum(int number1, int number2)
        {
            Log.Information($"'{number1}' ve '{number2}' değerleri toplanıyor...");

            return number1 + number2;
        }

        [McpServerTool, Description("İki sayının çarpımını döndürür...")]
        public static int Multiply(int number1, int number2)
        {
            Log.Information($"'{number1}' ve '{number2}' değerleri toplanıyor...");

            return number1 * number2;
        }
    }
}
