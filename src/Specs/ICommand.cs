using CommandSystem.Models;

namespace CommandSystem.Specs {
    public interface ICommand {
        CommandInfo Info { get; }
        void Execute(string[] args);
    }
}