# Browser-Sync Launcher

## v1.0.000

A GUI launcher for the [browser-sync](https://browsersync.io) development tool.

</br>

## Description

This tool is a GUI application designed to simplify the usage of the [browser-sync](https://browsersync.io) tool. It allows users to launch browser-sync or generate command-line commands for launching the tool with ease. By right-clicking inside any folder, users can select the "Host with Browser-Sync" option to specify the folder from which they want browser-sync to serve files. The GUI interface will then open, enabling users to configure desired options. Clicking the "Start" button will initiate the server, or users can copy the generated command to their clipboard for use in their preferred terminal.

Developed using the [Visual basic](https://learn.microsoft.com/en-us/dotnet/visual-basic/) [.NET 6.0 Windows Forms Application](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-6.0), this tool is compatible with Windows 7 and later operating systems. To ensure broad compatibility, the tool is compiled for the x86 architecture. It is self-contained, bundling all necessary dependencies except for the browser-sync tool and its dependencies, which users will need to install separately.

</br>

## Requirements

- [browser-sync](https://browsersync.io)

</br>

## Installation

- Install browser-sync using the following command:

```sh
npm install -g browser-sync
```

_Note: npm requires Node.JS to be installed._</br></br>
or visit the [browser-sync](https://browsersync.io) website for more information.</br>
_Ignore if already installed._

- Download and run the latest release ["browser-sync-launcher-v1.X.XXX-release-install.msi"]() file and follow the prompts.

</br>

## Usage

- After succesful installation, you can right-click inside any folder and select "Host with Browser-Sync" to launch the GUI.
- Alter the settings to your liking and click "Start" to initiate the server.
- You can also copy the generated command to your clipboard and use it in your preferred terminal.

</br>

## Uninstallation

- You can uninstall the program using the Windows Control Panel or Windows Settings.
- Alternatively, you can uninstall the program using the same MSI file you used for installation.

</br>

## License

This project is licensed under the [Apache-2.0](https://www.apache.org/licenses/LICENSE-2.0) License. For more details, please refer to the [LICENSE](LICENSE) file. This license is in accordance with the licensing of the browser-sync tool.

</br>

## Credits

I would like to express my gratitude to the [creators of the browser-sync](https://github.com/BrowserSync/browser-sync/graphs/contributors) tool for developing this remarkable tool.

</br>

## Future Plans

- I plan to incorporate additional features into this tool in the future, such as a "Settings" option that allows users to configure the launcher to open with custom user-defined options instead of predefined defaults.
- I also intend to add more browser-sync command options to the GUI.
- Further improvements will be made to enhance the UI.
- Extensive testing is required to ensure the GUI functions as intended. If you encounter any bugs, please report them.
- If you have any suggestions, please feel free to share them.

</br>

### Thank you for using this tool!

## This is [Jone Santhanaraj](https://github.com/jone-santhanaraj) signing off.
