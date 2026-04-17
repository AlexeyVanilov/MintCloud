using CommandSystem.Utils;
using CommandSystem.Specs;

namespace CommandSystem.Core {
    /// <summary>
    /// This class getting the command and proccesing it
    /// </summary>
    public static class CommandProcessor {
        public static bool Execute(ICommandService commandService, string input) {
            if (string.IsNullOrWhiteSpace(input)) {
                return false;
            }
            
            string[] parts = StringUtils.Dispatch(input);
            if (parts.Length == 0) return false;

            string name = parts[0];

            ICommand command;
            if(commandService.GetCommand(name, out command)) {
                string[] args = StringUtils.Slice(parts);
                command.Execute(args);
                return true;
            }
            return false;
        }
    }
}