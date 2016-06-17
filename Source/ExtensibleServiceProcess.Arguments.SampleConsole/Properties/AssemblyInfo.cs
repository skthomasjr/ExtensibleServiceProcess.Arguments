using System.Reflection;
using System.Runtime.InteropServices;
using ExtensibleServiceProcess;

[assembly: AssemblyTitle("Sample Service/Console")]
[assembly: AssemblyDescription("This is a sample service/console application used to demonstrate injecting the standard service control arguments into an ExtensibleServiceProcess application.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Sample Service/Console")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: Guid("bf21f6ff-a75a-44a2-ae6a-997373e7f4db")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: ServiceName("SampleServiceAndConsole")] // Comment out to use AssemblyTitle.
//[assembly: ServiceDisplayName("")] // Comment out to use AssemblyTitle.
//[assembly: ServiceDescription("")] // Comment out to use AssemblyDescription.