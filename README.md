# ToolkitPopupFlyoutExample
A repo showing a suspected bug in CommunityToolkit.Maui, where the underlying view disappears (similar to [issue #1416](https://github.com/CommunityToolkit/Maui/issues/1416)). However, unlike issue #1416, no popup is displayed at all. The project that exibits this behavior ([CornellPad](https://github.com/CornellPad/CornellPad)) has a flyout menu, and this behavior can be seen on all of the pages where the menu button is visible. But, the popups on the pages where the back button is present display just fine (I don't know if this is relevant). This led me to believe that the flyout button had something to do with it. Yet, this test project doesn't have a flyout menu defined at all and there is no menu button displayed. And the same behavior can be seen: when the "Show Popup" button is pressed, the entire view disappears and no popup is displayed.

**See the 'main' branch for the original test project; all changes/upgrades will be on separate branches.**

One test that I have yet to do, as of the writing of this readme, is to add a second page and a flyout menu to see if the popup would display while there is a back button in the UI. But, the first change that I would like to try is upgrading the project to .NET 8.0 to see if this issue was already fixed in the newer release. CornellPad is currently using .NET 7.0, which is why this test project started on .NET 7.0.

### System Details
* Mac Mini M1 (8GB)
* Sonoma 14.3.1
* Xcode 15.2
* Visual Studio for Mac 17.6.9
* All packages for Android, iOS, and MacOS have been installed by Visual Studio for Mac (there are no warnings in the IDE for any missing packages).

### Project Details
* .NET 7.0
* CommunityToolkit.Maui 6.1.0
* CommunityToolkit.Mvvm 8.2.1
* All other packages are either dependencies for CommunityToolkit.Maui, CommunityToolkit.Mvvm, or are standard packages that are included in the new .NET MAUI project template.
