using CommandSystem.Models;

namespace CommandSystem.Specs {
    public abstract class BaseCommand {
        public CommandInfo Info { get; init; }
        public abstract void Execute(string[] args);
    }
}