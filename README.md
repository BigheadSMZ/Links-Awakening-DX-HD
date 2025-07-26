# Links Awakening DX HD

This is an **unaffiliated fork** off [Link's Awakening DX HD](https://linksawakeningdxhd.itch.io/links-awakening-dx-hd). The goal of this fork is to implement all the various fixes and changes across all the various forks and hopefully implement some new ones to make the game behave closer to the original game. 

## Prerequisites

- Basic knowledge of C# and Visual Studio
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
    - Make sure to select `.NET desktop development` components in the visual studio installer.

## Build Instructions

- Clone this repository
- Open ProjectZ.sln
- Build/run like any normal C# program

## Build Troubleshooting

If you experience the error **The command “dotnet tool restore” exited with code 1** then make sure the file **.config\dotnet-tools.json** isn't blocked. To unblock, right click, go to Properties, check Unblock, and click OK.

## About This Fork

I am a terrible programmer, but I have a love for this game. A ton of forks popped up, some with fixes, but nowhere were they all centralized. This fork is an attempt to find and implement all the various fixes and improvements from the various forks, as well as hopefully add new fixes.

With that said, feel free to commit any potential fixes. There are no coding guidelines and any style is welcome as long as the code either fixes something broken or makes the game behave closer to the original. But do try to at least keep it neat.

## Publishing

To publish, you can run the `publish.bat`, which will produce the folder `Publish` that you can send to your friends.
