# mauilib-build-issue

A sample to highlight the Out of the Box issue with the Current Maui Template.

## Scenario

I want to build a cross-platform library using the new MauiLib template provided in VS & .NET 6 SDK

I want to keep the Platform implementations internal and expose only a single public class via an interface to the end user.

## Issue

When creating a new MauiLib project standalone, and trying to reference a Platform Specific class from a Shared class, an error occurs as there is no ".Net6.0" implementation

![Image showing Build Error](/assets/BuildError.png)


## Expected

I should be able to create a 'net6.0' only version of PlatformClass1.cs that follows the same pattern as the other Platform specific classes

## Things I've tried

In the old .net-sdk-extras method, you'd specify a version specific to .Net only, however, as suggested by Allan Ritchie to manually modify the csproj, this seems to be ignored.

The Maui Essentials works, because the port from Xamarin Essentials still uses the very manual way of explitily suffixing each file.

## Using

Maui Preview 11
VS2022 Preview 2
Single-project MSIX 0.9.10.2111041