namespace MintCloud.Utils {
    /// <summary>
    /// Static-class helper
    /// </summary>
    public static class StringUtils {
        public static string[] Dispatch(string input) =>
            input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        public static string[] Slice(string[] parts)
        {
            if (parts.Length <= 1) return Array.Empty<string>();

            string[] args = new string[parts.Length - 1];
            Array.Copy(parts, 1, args, 0, args.Length);
            return args;
        }
    }
}