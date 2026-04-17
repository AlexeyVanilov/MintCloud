namespace CommandSystem.Specs {
    public interface ICommandService {
        void Register(ICommand cmd);
        bool GetCommand(string s, out ICommand cmd);
        IEnumerable<ICommand> GetAllCommands();
        public int CommandsCount { get; }
        public bool CheckAliase(ICommand command);
    }
}