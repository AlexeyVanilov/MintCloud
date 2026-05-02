using CommandSystem.Models;
using CommandSystem.Specs;

namespace CommandSystem.Core {
    public sealed class CommandManager : BaseCommandSystem
    {
        private readonly Dictionary<string, BaseCommand> _commands = new(StringComparer.OrdinalIgnoreCase);

        public override void Register(BaseCommand cmd) {
            if (cmd == null) throw new ArgumentNullException(Messages.Get("onCommandNullValue"));
            _commands[cmd.Info.Name] = cmd;

            if (cmd.Info.Aliases != null) {
                foreach (var alias in cmd.Info.Aliases) {
                    _commands[alias] = cmd;
                }
            }
        }

        public override bool GetCommand(string name, out BaseCommand command)
            => _commands.TryGetValue(name, out command);

        public override IEnumerable<BaseCommand> GetAllCommands() => _commands.Values;

        public override int CommandsCount => _commands.Count;
        public override bool CheckAliase(BaseCommand command) => command.Info.Aliases != null && command.Info.Aliases.Length > 0;
    }
}