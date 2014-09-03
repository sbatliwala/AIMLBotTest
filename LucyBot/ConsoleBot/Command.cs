using System;
using System.Collections.Generic;

namespace LucyBot
{
    public class Command
    {
        public Command()
        {
            this.Arguments = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }


        public string Type { get; set; }

        public Dictionary<string, string> Arguments { get; private set; }
    }
}
