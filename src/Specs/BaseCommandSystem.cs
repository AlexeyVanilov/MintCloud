namespace CommandSystem.Specs {
    public abstract class BaseCommandSystem {
        public abstract void Register(ICommand cmd);
        public abstract bool GetCommand(string s, out ICommand cmd);
        public abstract IEnumerable<ICommand> GetAllCommands();
        public abstract int CommandsCount { get; }
        public abstract bool CheckAliase(ICommand command);
    }
}