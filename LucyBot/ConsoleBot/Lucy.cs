using System;
using AIMLbot;
using System.Xml;

namespace LucyBot
{
    public class Lucy
    {
        private static void Main()
        {
            var customBot = new Bot();
            customBot.loadSettings();
            var myUser = new User("saifuddin", customBot);
            customBot.isAcceptingUserInput = false;
            customBot.loadAIMLFromFiles();
            customBot.isAcceptingUserInput = true;
            while (true)
            {
                Console.Write("Human: ");
                var input = Console.ReadLine();
                if (input != null && input.ToLower() == "quit")
                {
                    break;
                }
                var r = new Request(input, myUser, customBot);
                var res = customBot.Chat(r);
                Console.WriteLine(res);
                var xdoc = new XmlDocument();
                string result = res as string;
                xdoc.LoadXml(res);
                var root = xdoc.DocumentElement;
                if (root.HasAttribute("type"))
                {
                    String type = root.GetAttribute("genre");
                    Console.WriteLine(type);

                    
                }
                Console.WriteLine("Lucy: " + res.Output);
            }
        }
    }
}
