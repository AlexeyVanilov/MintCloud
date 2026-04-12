namespace CommandSystem {
    /// <summary>
    /// this is a storage of commands
    /// </summary>
    public sealed class CommandManager : ICommandService {
        private readonly Dictionary<string, ICommand> _commands = new(StringComparer.OrdinalIgnoreCase);

        public void Register(ICommand cmd) => _commands[cmd.Info.Name] = cmd;

        public ICommand GetCommand(string name)
        {
            _commands.TryGetValue(name, out var cmd);
            return cmd;
        }
    }
}