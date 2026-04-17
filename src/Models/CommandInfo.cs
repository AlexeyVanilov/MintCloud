namespace CommandSystem.Models {
    /// <summary>
    /// Metadata of command
    /// </summary>
    public struct CommandInfo {
        public string Name { get; init; }
        public string[]? Aliases { get; init; }
        public string? Description { get; init; }
        public string? Usage { get; init; }
    }
}