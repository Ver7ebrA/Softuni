using System;
using System.Linq;
using System.Reflection;

using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";

        public CommandInterpreter()
        {

        }

        /// <summary>
        /// Parses the input and execute correct command
        /// </summary>
        /// <param name="args">Input</param>
        /// <returns></returns>

        public string Read(string args)
        {
            string[] commandTokens = args.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string commandName = commandTokens[0] + COMMAND_POSTFIX;
            string[] commandArgs = commandTokens.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();
            Type commandType = assembly.GetTypes().FirstOrDefault(t => t.Name.ToLower() == commandName.ToLower());

            if (commandType == null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            ICommand commandInstance = (ICommand)Activator.CreateInstance(commandType);

            string result = commandInstance.Execute(commandArgs);

            return result;
        }
    }
}
