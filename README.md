# blip-content-types-helper-csharp

[![Build status](https://ci.appveyor.com/api/projects/status/95ipu07bexcbom1y/branch/master?svg=true)](https://ci.appveyor.com/project/ravpacheco/blip-content-types-helper-csharp/branch/master)

A simple helper to make easy create BLiP documents (*netstandard2.0 compatible*).

This project is inspired on [BlipSDKHelperLibrary](https://github.com/andrebnassis/BlipSDKHelperLibrary) by [andrebnassis](https://github.com/andrebnassis).

## Intalling:

- Via Package Manager

`Install-Package Take.Blip.ContentTypesHelper`

- Via dotnet CLI

`dotnet add package Take.Blip.ContentTypesHelper`

## Using:

1. Sending text
```C#
  var text = BlipHelper.CreateText("... Inspiração, e um pouco de café! E isso me basta!");
  await _sender.SendMessageAsync(text, message.From, cancellationToken);
```
