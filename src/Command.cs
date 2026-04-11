namespace CommandSystem {
    /// <summary>
    /// Command that can takes some args
    /// </summary>
    public sealed class Command : ICommand {
        private readonly Action<string[]> _action;
        public CommandInfo Info { get; set; }

        public Command(string name, Action<string[]> action)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Error");
            _action = action ?? throw new ArgumentNullException(nameof(action));

            Info = new CommandInfo { Name = name };
        }
        public void Execute(string[] args) => _action?.Invoke(args);
    }
}