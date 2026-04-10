using System.Runtime.CompilerServices;

namespace CommandSystem {
    public sealed class Command {
        private readonly Action<string[]> _action;
        public CommandInfo Info;

        public Command(string name, Action<string[]> action)
        {
            Info = new CommandInfo { Name = name };
            _action = action;
        }
        /// <summary>
        /// auxillary functions
        /// </summary>
        /// <param name="args"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Execute(string[] args) => _action?.Invoke(args);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCommandUsage(string usage) => Info.Usage = usage;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCommandDescription(string description) => Info.Description = description;
        /// <summary>
        /// NOT recommended to use in any time. use only for initialize
        /// </summary>
        /// <param name="name"></param>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetCommandName(string name) => Info.Name = name;
    }
}