﻿namespace MediaFixer;

internal static class App
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Starting Media fix");
        await MediaFixer.FixMedia(ParseArguments(args));
        Console.WriteLine("Media fix completed");
        Console.ReadLine();
    }

    private static Dictionary<string, string?> ParseArguments(string[] args)
    {
        var parsed = new Dictionary<string, string?>();
        for (var i = 0; i < args.Length; i++)
        {
            if (!args[i].StartsWith("-"))
            {
                continue;
            }

            if (!args[i + 1].StartsWith("-"))
            {
                parsed.Add(args[i].Substring(1).ToLower(), args[i + 1].ToLower());
            }
            else
            {
                parsed.Add(args[i].Substring(1).ToLower(), null);
            }
        }
        return parsed;
    }
}
