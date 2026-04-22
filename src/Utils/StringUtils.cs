namespace CommandSystem.Utils {
    /// <summary>
    /// Static-class helper
    /// </summary>
    public static class StringUtils {
        public static string[] Dispatch(string input, char separator = ' ') {
            if (string.IsNullOrWhiteSpace(input)) return Array.Empty<string>();

            ReadOnlySpan<char> span = input.AsSpan().Trim();

            int wordCount = 0;
            foreach (var range in span.Split(separator))
            {
                if (!span[range].IsWhiteSpace()) wordCount++;
            }

            string[] output = new string[wordCount];
            int index = 0;

            foreach (var range in span.Split(separator))
            {
                var word = span[range];
                if (!word.IsWhiteSpace())
                {
                    output[index++] = word.ToString();
                }
            }

            return output;
        }
        public static string[] Slice(string[] parts)
        {
            if (parts.Length <= 1) return Array.Empty<string>();

            string[] args = new string[parts.Length - 1];
            Array.Copy(parts, 1, args, 0, args.Length);
            return args;
        }
    }
}