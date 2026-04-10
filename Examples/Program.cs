using CommandSystem;
using System.Runtime.CompilerServices;

namespace Examples {
    public static class Program {
        private static bool isRunning = true;
        public static bool IsRunning {
            get => isRunning;
            set => isRunning = value;
        }
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
                CommandProcessor.Execute(input);
            }
        }

        public static void SetupCommands()
        {
            Command echoCmd = new Command("echo", (args) => {
                if (args.Length == 0) {
                    SetColor(ConsoleColor.Red);
                    WriteLine("Enter message!");
                    return;
                }
                WriteLine(string.Join(" ", args));
            });

            Command exitCmd = new Command("exit", (args) => {
                IsRunning = false;
                SetColor(ConsoleColor.Red);
                WriteLine("Quit...");
            });

            CommandManager.Register(echoCmd);
            CommandManager.Register(exitCmd);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void WriteLine(string msg) => Console.WriteLine(msg);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetColor(ConsoleColor col) {
            Console.ForegroundColor = col;
        }
    }
}