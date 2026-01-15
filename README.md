# Suave.Razor

[![NuGet](https://img.shields.io/nuget/v/Suave.Razor.svg)](https://www.nuget.org/packages/Suave.Razor/)

Suave.Razor is a library that provides support for Razor views to the [Suave](https://suave.io/) web server framework. It enables you to use the powerful Razor templating engine with your F# Suave web applications.

## Features

- 🎨 **Razor Templates** - Use `.cshtml` files with full Razor syntax support
- 🔄 **Auto-reload** - Template changes are automatically detected and reloaded
- 🌍 **Localization** - Built-in support for localized views based on Accept-Language headers
- 📦 **Layouts** - Support for layout pages and sections
- 💾 **In-Memory Compilation** - Templates are compiled in memory for better performance
- 🔍 **View Resolution** - Intelligent view resolution with path-based lookups

## Installation

Add the Suave.Razor package to your project using the .NET CLI:

```bash
dotnet add package Suave.Razor
```

Or using Package Manager:

```powershell
Install-Package Suave.Razor
```

## Quick Start

### 1. Create a Basic View

Create a `Views` folder in your project and add a Razor view file `hello.cshtml`:

```cshtml
@model MyApp.Model

<h1>Hello @Model.Name!</h1>
<p>Welcome to Suave.Razor</p>
```

### 2. Define Your Model

```fsharp
type Model = { Name : string }
```

### 3. Use the Razor WebPart

```fsharp
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Razor

let app =
  choose [
    path "/hello" >=> razor "hello" { Name = "World" }
    RequestErrors.NOT_FOUND "Page not found"
  ]

startWebServer defaultConfig app
```

That's it! Navigate to `http://localhost:8080/hello` to see your rendered view.

## Usage Examples

### Basic Example

```fsharp
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Razor

type Person = { Name : string; Age : int }

let app =
  choose [
    path "/" >=> razor "index" { Name = "Alice"; Age = 30 }
  ]

startWebServer defaultConfig app
```

**Views/index.cshtml:**
```cshtml
@model Person

<html>
<head><title>Person Info</title></head>
<body>
  <h1>@Model.Name</h1>
  <p>Age: @Model.Age</p>
</body>
</html>
```

### Using Layouts

Create a layout file to share common structure across multiple views.

**Views/layout.cshtml:**
```cshtml
<!DOCTYPE html>
<html lang="en">
<head>
    <title>@ViewBag.Title</title>
    <meta charset="utf-8" />
    @RenderSection("Styles", required: false)
</head>
<body>
    <header>
        <h1>My Suave App</h1>
    </header>
    
    <main>
        @RenderBody()
    </main>
    
    <footer>
        <p>&copy; 2025 My Application</p>
    </footer>
    
    @RenderSection("Scripts", required: false)
</body>
</html>
```

**Views/page.cshtml:**
```cshtml
@model MyModel
@{
    Layout = "layout.cshtml";
    ViewBag.Title = "My Page";
}

@section Styles {
    <link rel="stylesheet" href="/css/page-specific.css" />
}

<div>
    <h2>Page Content</h2>
    <p>@Model.Content</p>
</div>

@section Scripts {
    <script src="/js/page-specific.js"></script>
}
```

### Working with Lists

**F# Code:**
```fsharp
type Entry = { Name : string; Age : int }

type DataModel = {
    Title : string
    Items : Entry list
}

let app =
  path "/people" >=> razor "people" {
    Title = "People List"
    Items = [
      { Name = "Alice"; Age = 30 }
      { Name = "Bob"; Age = 25 }
      { Name = "Charlie"; Age = 35 }
    ]
  }
```

**Views/people.cshtml:**
```cshtml
@model DataModel

<h1>@Model.Title</h1>
<ul>
@foreach (var item in Model.Items)
{
    <li>@item.Name (Age: @item.Age)</li>
}
</ul>
```

### Accessing HTTP Context

The HTTP context is available through the `ViewBag` in your Razor views:

```cshtml
@{
    var context = ViewBag.HttpContext;
    var url = context.request.url;
}

<p>Current path: @url.AbsolutePath</p>
```

### Using View Imports

Create a `_ViewImports.cshtml` file in your Views folder to add common `@using` statements:

**Views/_ViewImports.cshtml:**
```cshtml
@using System
@using System.Linq
@using System.Collections.Generic
```

## Localization Support

Suave.Razor automatically supports localized views based on the `Accept-Language` header. Views are resolved in the following order:

1. `ViewName-{culture}.cshtml` (e.g., `home-en-US.cshtml`)
2. `ViewName.cshtml` (fallback to default view)

**Example:**
- `Views/home.cshtml` - Default view
- `Views/home-es-ES.cshtml` - Spanish (Spain) version
- `Views/home-fr-FR.cshtml` - French (France) version

The appropriate view will be automatically selected based on the client's language preferences.

## View Resolution

Views are resolved in the following order:

1. Relative to the current request path (e.g., for `/admin/users`, checks `/Views/admin/users.cshtml`)
2. In parent directories up to the root
3. In the root Views directory
4. In the application root directory

This allows for flexible view organization and path-based overrides.

## Configuration

### Custom Home Directory

By default, views are resolved relative to the Suave `homeDirectory` configuration:

```fsharp
let config = {
  defaultConfig with
    homeDirectory = Some "/path/to/your/app"
}

startWebServer config app
```

Views should be placed in a `Views` subfolder within the home directory.

## API Reference

### `razor<'a> : string -> 'a -> WebPart`

Creates a WebPart that renders a Razor view with the specified model.

**Parameters:**
- `path` - The name of the view file (without `.cshtml` extension)
- `model` - The model object to pass to the view

**Returns:**
- A `WebPart` that renders the view with the model

**Example:**
```fsharp
path "/user" >=> razor "userProfile" { UserId = 123; UserName = "Alice" }
```

## Advanced Features

### Template Caching

Templates are automatically cached and invalidated when the source file changes. This provides optimal performance while allowing for rapid development with auto-reload.

### In-Memory Compilation

By default, Razor templates are compiled in memory rather than written to temporary files. This improves performance and reduces disk I/O.

## Requirements

- .NET 10.0 or later
- Suave 3.2.1 or later

## Example Project

The `Suave.Razor.Tests` project in this repository contains a working example application demonstrating various features:

- Basic views
- Layout pages
- Sections
- Lists and data binding
- MVC Grid integration

To run the example:

```bash
cd Suave.Razor.Tests
dotnet run
```

Then open your browser to `http://localhost:8080/test1` to see the examples in action.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

## License

Copyright 2020 Ademar Gonzalez and contributors

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

## Links

- [Suave Web Server](https://suave.io/)
- [Razor Documentation](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor)
- [GitHub Repository](https://github.com/SuaveIO/Suave.Razor)
- [NuGet Package](https://www.nuget.org/packages/Suave.Razor/)
