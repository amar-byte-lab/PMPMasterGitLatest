using System;
using System.Threading;

namespace ApplicationInterface
{
    public static class LayerInterfaceExtensions
    {
        public static bool ExecuteCommand(this LayerInterface layerInterface, string command, string portName)
        {
            if (string.IsNullOrWhiteSpace(command)) return true;

            string[] subCommands = command.Split('|');
            foreach (var sub in subCommands)
            {
                string trimmedSub = sub.Trim();
                if (string.IsNullOrEmpty(trimmedSub)) continue;

                if (trimmedSub.StartsWith("wait ", StringComparison.OrdinalIgnoreCase))
                {
                    string timePart = trimmedSub.Substring(5).Trim();
                    string[] timeParts = timePart.Split(':');
                    int totalMilliseconds = 0;
                    if (timeParts.Length == 3)
                    {
                        int.TryParse(timeParts[0], out int h);
                        int.TryParse(timeParts[1], out int m);
                        int.TryParse(timeParts[2], out int s);
                        totalMilliseconds = ((h * 3600) + (m * 60) + s) * 1000;
                    }
                    else
                    {
                        int.TryParse(timePart, out int s);
                        totalMilliseconds = s * 1000;
                    }

                    if (totalMilliseconds > 0)
                    {
                        Thread.Sleep(totalMilliseconds);
                    }
                }
                else
                {
                    Thread.Sleep(200);
                    Console.WriteLine($"[SIMULATION] Port {portName} executed command: {trimmedSub}");
                }
            }

            return true;
        }
    }
}
