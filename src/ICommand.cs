namespace CommandSystem {
    public interface ICommand {
        CommandInfo Info { get; }
        void Execute(string[] args);
    }
}