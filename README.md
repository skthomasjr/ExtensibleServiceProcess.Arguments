# ExtensibleServiceProcess.Arguments

[![Build](https://ci.appveyor.com/api/projects/status/9tilmwq1glvuqo7e?svg=true)](https://ci.appveyor.com/project/skthomasjr/extensibleserviceprocess-arguments)
[![Release](https://img.shields.io/github/release/skthomasjr/ExtensibleServiceProcess.Arguments.svg?maxAge=2592000)](https://github.com/skthomasjr/ExtensibleServiceProcess.Arguments/releases)
[![NuGet](https://img.shields.io/nuget/v/ExtensibleServiceProcess.Arguments.svg)](https://www.nuget.org/packages/ExtensibleServiceProcess.Arguments)
[![License](https://img.shields.io/github/license/skthomasjr/ExtensibleServiceProcess.Arguments.svg?maxAge=2592000)](LICENSE.md)
[![Author](https://img.shields.io/badge/author-Scott%20K.%20Thomas%2C%20Jr.-blue.svg?maxAge=2592000)](https://www.linkedin.com/in/skthomasjr)
[![Join the chat at https://gitter.im/skthomasjr/ExtensibleServiceProcess.Arguments](https://badges.gitter.im/skthomasjr/ExtensibleServiceProcess.Arguments.svg)](https://gitter.im/skthomasjr/ExtensibleServiceProcess.Arguments?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

ExtensibleServiceProcess.Arguments is the integration of Arguments.NET into ExtensibleServiceProcess.

Install the NuGet package:
```
PM> Install-Package ExtensibleServiceProcess.Arguments
```
Use your favorite IoC container to inject instances of IArgument into the ArgumentManager. See the sample code for additional details.

The following arguments will be supported for your implementation of ExtensibleServiceBase:
```
-i, -install     Install the Windows service.
-u, -uninstall   Uninstall the Windows service.
-s, -start       Start the Windows service.
-t, -stop        Stop the Windows service.
```
