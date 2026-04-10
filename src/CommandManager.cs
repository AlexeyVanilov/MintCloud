using System.Runtime.CompilerServices;

namespace CommandSystem {
    /// <summary>
    /// this is a storage of commands
    /// </summary>
    public static class CommandManager
    {
        private static readonly Dictionary<string, Command> _commands = new(StringComparer.OrdinalIgnoreCase);

        public static void Register(Command cmd) => _commands[cmd.Info.Name] = cmd;

        public static Command GetCommand(string name)
        {
            _commands.TryGetValue(name, out var cmd);
            return cmd;
        }
    }
}