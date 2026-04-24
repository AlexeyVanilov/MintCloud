namespace CommandSystem.Core {
    public sealed class CommandEventResult {
        public Action<string> onCommandAccepted;
        public Action<string> onCommandNotFound;
    }
}