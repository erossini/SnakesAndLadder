# Snakes And Ladder
A C# implementation of Snakes and Ladders Kata (https://agilekatas.co.uk/katas/snakesandladders-kata)

# Specflow
Specflow is working with .NET Framework. I'm using for this project .NET Core. For this reason I'm using the new preview.

The first public preview of SpecFlow with support for .NET Core is now available. If you want to try out the new version, please read the following information carefully. There are a number of steps that are necessary before you can use the public preview.

You download the latest version of Specflow from https://specflow.org/2018/specflow-3-public-preview-now-available/

## Installing the Preview Visual Studio Extension
SpecFlow 3 requires an update to the Visual Studio extension for SpecFlow. During the preview period, you will need to connect to the following feed to download the preview version of the extension:
https://www.myget.org/F/specflow-vsix/vsix/

To do so:
- Select Tools | Options in Visual Studio.
- Locate Environment in the list, and select the Extensions and Updates sub-item.
- Click on Add to add a new feed.
- Give the new source a Name (e.g. “SpecFlow 3 preview”) and enter the source (“https://www.myget.org/F/specflow-vsix/vsix/”).
- Select Tools | Extensions and Updates. You should see an update listed on the left.
- Click on Updates to update the new extension.

Once a stable version of SpecFlow 3 has been released, the new version of the extension will go live for all users, and you can revert to the standard feed.