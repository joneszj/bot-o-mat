# Bot-O-Mat!

A simple application to create bots and assign them tasks, with a twist (if a bot fails a task, it has a chance to destroy another bot!)

## Requirements
 - C# 7.1+
 - .Net Core 2.2+
 - Visual Studio 2017+ (built using [Visual Studio 2019 Preview]([https://visualstudio.microsoft.com/vs/preview/](https://visualstudio.microsoft.com/vs/preview/)))
 - [Browser with ES 8](https://www.w3schools.com/js/js_versions.asp)+

## Setup

 1. Restore Project NuGet Dependencies
	 *	r-click Solution (Bot-O-Mat)
	 *	l-click Restore Nuget Packages
 2. Restore Client-Side Libraries in Bot-O-Mat.Web
	 * (open) Bot-O-Mat.Web > libman.json 
	 * Save (ctrl + s) (ignore typescript update install notificaiton if prompted)
 3. Perform Database Migrations
	 * Set Bot-O-Mat.API as Startup Project
		 * r-click Bot-O-Mat.API
		 * l-click Set as Startup Project
	 * Open Package Manager
		 * View > Other Windows > Package Manager Console (or alt + t + n + o)
		 * run "update-database -c botomatcontext -p bot-o-mat.api"
			 * This takes a few minutes to complete db seed
 4. Set Startup Projects
	 * r-click Solution
	 * l-click Set Startup Projects
	 * l-click Multiple Startup Projects
	 * Set "Start" for projects: (Bot-O-Mat.API, Bot-O-Mat.Web.Angular)
	 * Include Bot-O-Mat.Generator to simulate real-time traffic & communications via SignalR
 5. Rebuild Projects
	 * ctrl + shift + b

## Run
1. F5 or l-click Start

## Acceptance Criteria
* [https://github.com/RedVentures22/bot-o-mat-joneszj](https://github.com/RedVentures22/bot-o-mat-joneszj)
* Creative Liberty: I wanted a theme where the user can generate bots as noted in the AC, but with the twist that the bots don't always behave as instructed. They may failed to perform any given task, and target another bot to destroy.

## Concepts
1. API: manages all IO for the persistence layer and enforces business logic
	* includes SignalR notifications service 
2. Razor: hosting server for web UI 
	* SPA-ish UI. Server handles initial request. Subsequent UI updates are managed in JavaScript (site.js)
3. BotGenerator: simulates IO from random users and fits the theme of bots going haywire
4. Angular: simplified UI built in Angular

## Hindsight Considerations
- Enum support for [EF]([https://docs.microsoft.com/en-us/ef/core/modeling/value-conversions](https://docs.microsoft.com/en-us/ef/core/modeling/value-conversions)) and [Razor]([https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.html.selectextensions.enumdropdownlistfor?view=aspnet-mvc-5.2](https://docs.microsoft.com/en-us/dotnet/api/system.web.mvc.html.selectextensions.enumdropdownlistfor?view=aspnet-mvc-5.2)) is cool, but implementation adds bloated implementation logic for Enum string parsing and is not as flexible as a simple POCO.

## Future Considerations
- Razor:
- Implement a [ChatBot]([https://dev.botframework.com/](https://dev.botframework.com/)) to facilitate communicating with the bots
- Implement real-time updates on UI
- Implement server and client-side caching layers
- UI can use a CSS touchup 
- Take advantage of the ErrandActor base class to remove some of the duplication code of its derived classes
- Angular:
- Add more views (matching .Razor proj)
