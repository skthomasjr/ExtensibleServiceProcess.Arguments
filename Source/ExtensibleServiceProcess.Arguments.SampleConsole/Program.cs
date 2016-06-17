using System;
using System.ComponentModel.Composition.Hosting;
using Arguments;

namespace ExtensibleServiceProcess.Arguments.SampleConsole
{
    /// <summary>
    /// The application service.
    /// </summary>
    /// <seealso cref="ExtensibleServiceProcess.ExtensibleServiceBase" />
    internal class Service : ExtensibleServiceBase
    {
        /// <summary>
        /// Prevents a default instance of the <see cref="Service"/> class from being created.
        /// </summary>
        private Service()
        {
            AllowMultipleServiceStarts = false;
            AutoLog = true;
            CanHandlePowerEvent = false;
            CanHandleSessionChangeEvent = false;
            CanPauseAndContinue = false;
            CanShutdown = false;
            CanStop = true;
            ExitCode = 0;
        }

        /// <summary>
        /// Defines the entry point of the application. See AssemblyInfo.cs for example of how to set service name, display name, and description.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>System.Int32.</returns>
        internal static int Main(string[] args)
        {
            // Important Note: You should run as Administrator to interact with the service control manager.
            
            // Override the passed arguments for testing purposes. Use '-', '--', '/', or '//' as flags.
            // Uncomment one to test the service control arguments.

            //args = new[] { "-i" }; // or "install"
            //args = new[] { "-u" }; // or "uninstall"
            //args = new[] { "-s" }; // or "start"
            //args = new[] { "-t" }; // or "stop"

            using (var catalog = new ApplicationCatalog())
            using (var container = new CompositionContainer(catalog))
            using (var service = container.GetExport<ExtensibleServiceBase>()?.Value as Service)
            {
                if (service == null) return 1;

                Console.Title = "Sample Console";
                Console.CursorVisible = false;

                var argumentsToInject = container.GetExportedValues<IArgument>();
                var arguments = global::Arguments.Arguments.NewArguments(args, argumentsToInject);
                arguments.Process();

                if (Environment.UserInteractive)
                {
                    service.OnStart(args);

                    Console.WriteLine();
                    Console.WriteLine("This application will run as a console application and a service application.");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();

                    service.OnStop();
                }
                else
                {
                    Run(service);
                }
            }

            return 0;
        }
    }
}