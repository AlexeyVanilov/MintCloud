using CommandSystem.Logs;

namespace CommandSystem {
    public sealed class CommandManager : ICommandService
    {
        private readonly Dictionary<string, ICommand> _commands = new(StringComparer.OrdinalIgnoreCase);

        public void Register(ICommand cmd)
        {
            if (cmd == null) throw new ArgumentNullException(ErrorLog.nullCommandValue);
            _commands[cmd.Info.Name] = cmd;

            if (cmd.Info.Aliases != null) {
                foreach (var alias in cmd.Info.Aliases) {
                    _commands[alias] = cmd;
                }
            }
        }

        public bool GetCommand(string name, out ICommand command)
            => _commands.TryGetValue(name, out command);

        public IEnumerable<ICommand> GetAllCommands() => _commands.Values;

        public int CommandsCount => _commands.Count;
        public bool CheckAliase(ICommand command) => command.Info.Aliases != null && command.Info.Aliases.Length > 0;
    }
}