# Calculator

- Application by <a href="http://jrliv.com/about/" target="_blank">Jae Logan</a>
- UFT project by Baetens Jan

## Description

A simple desktop calculator created with C#. I created this project to practice working with classes, objects, and methods. Which is why I seperated the project code into GUI (<a href="https://github.com/jrliv/Calculator/blob/master/Calculator/MainWindow.xaml.cs" target="_blank">MainWindow.xaml.cs</a>) and calculation (<a href="https://github.com/jrliv/Calculator/blob/master/Calculator/Calculate.cs" target="_blank">Calculate.cs</a>) logic parts.

## Installation

To start using and testing this application, make sure the following programs and settings are installed.

- Visual Studio 2017 (with .NET WPF modules installed)
- UFT Developer 15.0.2 (or compatible) runtime and IDE addon

In the tests change the Desktop.LaunchAut("<FilePath>") to where the executable to test is located on your machine.
Create the Aut whitelist file in the "%localappdata%/LeanFT/config" folder and name it "autConfig.json".

Inside the "autConfig.json" file place the following:

{
    "allowedAuts": [
        {
			"fileName": "<FilePath>"
        }
    ]
}

## Known Issues

- Make sure your windows display has scaling set as 100%. The testing framework will fail if this is not set correctly.

## Usage

Feel free to do whatever you want with this project. I'm not planning on changing or updating it so I included the executable file. If you're using Windows and you just want to run and play with it you can download and run <a href="https://github.com/jrliv/Calculator/blob/master/Calculator/bin/Debug/Calculator.exe" target="_blank">the executable</a>.



