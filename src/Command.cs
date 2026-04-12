using CommandSystem.Logs;

namespace CommandSystem {
    /// <summary>
    /// Command that can takes some args
    /// </summary>
    public sealed class Command : ICommand {
        private readonly Action<string[]> _action;
        public CommandInfo Info { get; }

        public Command(string name, Action<string[]> action, string description = "", string usage = "")
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException(ErrorLog.nullCommandName);
            _action = action ?? throw new ArgumentNullException(nameof(action));

            Info = new CommandInfo { Name = name, Description = description, Usage = usage };
        }
        public void Execute(string[] args) => _action?.Invoke(args);
    }
}