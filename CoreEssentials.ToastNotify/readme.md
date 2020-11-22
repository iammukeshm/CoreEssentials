# Toast Notify - Elegant Notifications For ASP.NET Core Applications

Toast Notify is a Minimal & Elegant Toast Notification Package for ASP.NET Core Applications that can be invoked via C#. Compatilble with ASP.NET Core 3.1 and .NET 5.

![Toast Notify ](https://media.giphy.com/media/f5jXGMSqkdGcVh0WbZ/source.gif)

## Features

- 📱 Elegant & Responsive
- 🎸 Easily integration with ASP.NET Core 3.1 and .NET 5 Applications.
- 🎃 Support to render custom HTML content within the toasts
- 🐣 Simple and Customizable. Create your own custom toast with your favorite color and icons with ease!
- 👴🏽 Works with TempData internally.

More Features Coming Soon.


## Installation

```
Install-Package CoreEssentials.ToastNotify
```
Or

```
dotnet add package CoreEssentials.ToastNotify
```

## Demo

A Demo Implementation using ASP.NET Core MVC can be found here - https://github.com/iammukeshm/CoreEssentials/tree/master/CoreEssentials.ToastNotify.Demo

## Usage

Once tha package is installed, open your Startup.cs and add in the following to the ConfigureServices method.

```csharp
services.AddToastNotify();
```

> More settings will be added in the upcoming releases

Next, open up your _Layout.cshml file and add in the following

```
 @await Component.InvokeAsync("ToastNotify")
```
> Make sure that you add this line after loading jquery. It is usually ideal to place this code below the essential scripts and above the  @await RenderSectionAsync("Scripts", required: false) line.

Let's add the Constructor Injection. Add the following in your controllers / razor classes to invoke the toast notifications as required.

```
public IToastNotifyService _notifyService { get; }
public HomeController( IToastNotifyService notifyService)
{
    _notifyService = notifyService;
}
```
Once the Injection is done, you can call the toast notification as you need. Currently 5 Types are supported.

### Success
```csharp
_notifyService.Success("This is a Success Notification");
```

### Error
```csharp
_notifyService.Error("This is an Error Notification");
```

### Warning
```csharp
_notifyService.Warning("This is a Warning Notification");
```

### Information
```csharp
_notifyService.Information("This is an Information Notification");
```
#### Set Toast Duration
You can set the duration(in seconds) after which the toast will be dismissed.
```csharp
_notifyService.Success("This toast will be dismissed in 10 seconds.",10);
```
## Custom
As the previous 4 Modes are very static in terms of color and icon, I have added a 5th type that let's you customize everything.

```csharp
_notifyService.Custom("Custom Orange Notification with Gear Icon from Font Awesome that closes in 10 seconds.", "orange", "fa fa-gear",10);
_notifyService.Custom("Custom Green Notification with Gear Icon from Font Awesome that closes in 10 seconds.", "#135224", "fa fa-gear",10);
            
```
Here, you add the class of the icon as required. Font Awesome icons are supported by default. You would just have to pass the icon class name. The color of the text and icon is automatically set based on the color of the notification. Supports HEXR Color Codes too!

### Mentions

The Javascript library used in this project is https://github.com/caroso1222/notyf. I used this library to create a cool abstraction for ASP.NET Core applications.

## Support
Has this Project helped you learn something New? or Helped you at work? Do Consider Supporting.

<a href="https://www.buymeacoffee.com/codewithmukesh" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" width="200"  ></a>

## About the Author
### Mukesh Murugan
- Blogs at [codewithmukesh.com](https://www.codewithmukesh.com)
- Facebook - [codewithmukesh](https://www.facebook.com/codewithmukesh)
- Twitter - [Mukesh Murugan](https://www.twitter.com/iammukeshm)
- Twitter - [codewithmukesh](https://www.twitter.com/codewithmukesh)
- Linkedin - [Mukesh Murugan](https://www.linkedin.com/in/iammukeshm/)
