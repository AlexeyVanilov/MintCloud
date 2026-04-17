using CommandSystem;
using System.Runtime.CompilerServices;

namespace Examples {
    public static class Program {
        private static bool isRunning = true;
        public static bool IsRunning {
            get => isRunning;
            set => isRunning = value;
        }
        private static ICommandService commandManager;
        /// <summary>
        /// test commands
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args) {
            SetupCommands();
            SetColor(ConsoleColor.Green);
            WriteLine("please, enter command:");
            /// <summary>
            /// Main Program Loop
            /// </summary>
            while (IsRunning) {
                string? input = Console.ReadLine();
                CommandProcessor.Execute(commandManager, input);
            }
        }
        /// <summary>
        /// Example functions
        /// </summary>
        public static void SetupCommands()
        {
            commandManager = new CommandManager();
            ICommand echoCmd = new Command("echo", (args) => {
                if (args.Length == 0) {
                    SetColor(ConsoleColor.Red);
                    WriteLine("Enter message!");
                    return;
                }
                WriteLine(string.Join(" ", args));
            }, aliases: new[] {"e", "msg"});
            ICommand exitCmd = new Command("exit", (args) => {
                IsRunning = false;
                SetColor(ConsoleColor.Red);
                WriteLine("Quit...");
            }, aliases: new[] { "quit" });

            commandManager.Register(echoCmd);
            commandManager.Register(exitCmd);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLine(string msg) => Console.WriteLine(msg);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetColor(ConsoleColor col) {
            Console.ForegroundColor = col;
        }
    }
}