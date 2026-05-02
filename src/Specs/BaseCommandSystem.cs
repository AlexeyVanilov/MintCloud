namespace CommandSystem.Specs {
    public abstract class BaseCommandSystem {
        public abstract void Register(BaseCommand cmd);
        public abstract bool GetCommand(string s, out BaseCommand cmd);
        public abstract IEnumerable<BaseCommand> GetAllCommands();
        public abstract int CommandsCount { get; }
        public abstract bool CheckAliase(BaseCommand command);
    }
}