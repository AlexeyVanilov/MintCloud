using CommandSystem.Utils;
using CommandSystem.Specs;
using CommandSystem.Models;

namespace CommandSystem.Core {
    /// <summary>
    /// This class getting the command and processing it
    /// </summary>
    public static class CommandProcessor {
        public static bool Execute(BaseCommandSystem commandService, CommandEventResult commandEventResult, string input) {
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
                commandEventResult.onCommandAccepted?.Invoke(Messages.Get("onCommandAccepted"));
                return true;
            }
            commandEventResult.onCommandNotFound?.Invoke(Messages.Get("onCommandNotFound"));
            return false;
        }

        public static Task<bool> AsyncExecute(BaseCommandSystem commandService, CommandEventResult commandEventResult, string input) {
            return Task.Run(() => Execute(commandService, commandEventResult, input));
        }
    }
}