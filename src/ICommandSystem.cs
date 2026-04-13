namespace CommandSystem {
    public interface ICommandService {
        void Register(ICommand command);
        ICommand GetCommand(string s);
    }
}