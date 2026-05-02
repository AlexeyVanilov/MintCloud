namespace CommandSystem.Models {
    /// <summary>
    /// Message logs system
    /// </summary>
    public static class Messages {
        private static Dictionary<string, string> messageLogs = new();
        public static void Register(string key, string value) => messageLogs.Add(key, value);
        public static string Get(string key) {
            if(!messageLogs.ContainsKey(key)) {
                return string.Empty;
            }
            return messageLogs[key];
        }

        public static int MessageLogsCount => messageLogs.Count;

        static Messages() {
            Register("onCommandAccepted", "Command has been successfully processed!");
            Register("onCommandNotFound", "Command has been failed!");
            Register("onNullCommand", "Command name cannot be null!");
            Register("onCommandNullValue", "Command value cannot be null!");
        }
    }
}