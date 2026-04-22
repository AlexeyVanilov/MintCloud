using CommandSystem.LogSystem;
using CommandSystem.Specs;

namespace CommandSystem.Core {
    public sealed class CommandManager : BaseCommandSystem
    {
        private readonly Dictionary<string, ICommand> _commands = new(StringComparer.OrdinalIgnoreCase);

        public override void Register(ICommand cmd) {
            if (cmd == null) throw new ArgumentNullException(ErrorLog.nullCommandValue);
            _commands[cmd.Info.Name] = cmd;

            if (cmd.Info.Aliases != null) {
                foreach (var alias in cmd.Info.Aliases) {
                    _commands[alias] = cmd;
                }
            }
        }

        public override bool GetCommand(string name, out ICommand command)
            => _commands.TryGetValue(name, out command);

        public override IEnumerable<ICommand> GetAllCommands() => _commands.Values;

        public override int CommandsCount => _commands.Count;
        public override bool CheckAliase(ICommand command) => command.Info.Aliases != null && command.Info.Aliases.Length > 0;
    }
}