namespace CommandSystem {
    /// <summary>
    /// This class getting the command and proccesing it
    /// </summary>
    public static class CommandProcessor {
        public static bool Execute(string input) {
            if (string.IsNullOrWhiteSpace(input)) return false;

            string[] parts = Dispatch(input);
            if (parts.Length == 0) return false;

            string name = parts[0];

            Command command = CommandManager.GetCommand(name);

            if (command != null) {
                string[] args = new string[parts.Length - 1];
                Array.Copy(parts, 1, args, 0, parts.Length - 1);

                command.Execute(args);
                return true;
            }
            return false;
        }

        private static string[] Dispatch(string input) =>
            input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }
}