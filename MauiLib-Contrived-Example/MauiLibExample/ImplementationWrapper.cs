namespace MauiLibExample;

// All the code in this file is included in all platforms.
public class ImplementationWrapper : IImplementationWrapper
{
    public void DoSomething()
    {
        var platformImplementation = new PlatformClass1();
        platformImplementation.DoSomethingPlatformSpecific();        
    }
}
