using CommandSystem.Models;
using CommandSystem.Specs;

namespace CommandSystem.Core {
    /// <summary>
    /// Command that can takes some args
    /// </summary>
    public sealed class Command : BaseCommand {
        private readonly Action<string[]> _action;

        public Command(string name, Action<string[]> action, string[]? aliases = null, string? description = null, string? usage = null)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException(Messages.Get("onNullCommand"));
            _action = action ?? throw new ArgumentNullException(nameof(action));

            Info = new CommandInfo { Name = name, Aliases = aliases, Description = description, Usage = usage };
        }
        public override void Execute(string[] args) => _action?.Invoke(args);
    }
}