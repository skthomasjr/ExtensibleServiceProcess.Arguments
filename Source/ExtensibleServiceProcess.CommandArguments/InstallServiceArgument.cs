using System;
using CommandArguments;

namespace ExtensibleServiceProcess.CommandArguments
{
    /// <summary>
    /// Class InstallServiceArgument.
    /// </summary>
    /// <seealso cref="IArgument" />
    public class InstallServiceArgument : IArgument
    {
        /// <summary>
        /// The action to perform when the argument is specified.
        /// </summary>
        /// <value>The action.</value>
        public Action<string> Action { get; set; }

        /// <summary>
        /// The possible flags used to denote the argument.
        /// </summary>
        /// <value>The flags.</value>
        public string[] Flags { get; set; } = { "i", "install" };

        /// <summary>
        /// Determines if additional arguments should be processed if this argument is encountered and executed.
        /// </summary>
        /// <value><c>true</c> if [terminate after execution]; otherwise, <c>false</c>.</value>
        public bool TerminateAfterExecution { get; set; } = true;
    }
}
