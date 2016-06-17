using System;
using System.ComponentModel.Composition;
using Arguments;

namespace ExtensibleServiceProcess.Arguments
{
    /// <summary>
    /// The argument used to start an ExtensibleServiceProcess application.
    /// </summary>
    /// <seealso cref="IArgument" />
    public class StartServiceArgument : IArgument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartServiceArgument"/> class.
        /// </summary>
        /// <param name="service">The argument action target service.</param>
        [ImportingConstructor]
        public StartServiceArgument(ExtensibleServiceBase service)
        {
            Action = StartService;
            Target = service;
        }

        /// <summary>
        /// The action to perform when the argument is specified.
        /// </summary>
        /// <value>The action.</value>
        public Action<object, string> Action { get; set; }

        /// <summary>
        /// The possible flags used to denote the argument.
        /// </summary>
        /// <value>The flags.</value>
        public string[] Flags { get; set; } = { "s", "start" };

        /// <summary>
        /// Gets or sets the argument action target.
        /// </summary>
        /// <value>The target.</value>
        public object Target { get; set; }

        /// <summary>
        /// Determines if additional arguments should be processed if this argument is encountered and executed.
        /// </summary>
        /// <value><c>true</c> if terminate after execution; otherwise, <c>false</c>.</value>
        public bool TerminateAfterExecution { get; set; } = true;

        private void StartService(object target, string parameter)
        {
            var service = target as ExtensibleServiceBase;
            service?.StartService();
        }
    }
}