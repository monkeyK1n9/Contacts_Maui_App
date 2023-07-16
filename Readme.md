# Contacts

I'm just walking around trying to learn the new .NET MAUI framework
from Microsoft to build cross-platform apps.

## Introduction

This is a cross-platform solution to store and edit contacts.

## Setup

You will need to install dotnet to run C#.
Installing the .NET MAUI workloads

In a command prompt or terminal, run the following command to install the .NET MAUI workloads

```dotnet workload install maui```
If you have trouble with the dotnet command not being found, then open the Developer Command Prompt for VS 2022 Preview and try it again.

Verifying and installing missing components maui-check utility
The maui-check utility is a command line tool that verifies your development environment and installs any missing components.

Run the following .NET Command Line Interface (.NET CLI) command to install the maui-check utility:

```dotnet tool install -g redth.net.MAUI.check```
If you already have a previous version of maui-check installed, update it to the latest version with the following .NET CLI command:

```dotnet tool update -g redth.net.MAUI.check```
Finally, run the following command to check your development environment:

```maui-check```

Launch the required emulator and you are good to go.

## Contributions

You can fire issues or contribute anytime, this is a learning project.