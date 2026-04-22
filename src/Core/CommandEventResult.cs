namespace CommandSystem.Core {
    public static class CommandEventResult {
        public static Action<string> onCommandAccepted;
        public static Action<string> onCommandNotFound;
    }
}