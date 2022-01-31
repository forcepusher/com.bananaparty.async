# com.bananaparty.async  
  
Unity package. Asynchronous programming library for strict-OOP.  
In contrast to traditional language-specific patterns, it does not rely on a static execution context.  
Does not reference Unity Engine, so it could be used in a regular C# project.  
  
Make sure you have standalone [Git](https://git-scm.com/downloads) installed first.  
In Unity, open "Window" -> "Package Manager".  
Click the "+" sign on top left corner -> "Add package from git URL..."  
Paste this: `https://github.com/forcepusher/com.bananaparty.async.git#1.0.1`  
See minimum required Unity version in the `package.json` file.  
  
---  
  
All of these are not suitable for strict-OOP. They've copied the same mistake from each other.  
[C# TAP (async/await) SynchronizationContext](https://docs.microsoft.com/en-us/dotnet/api/system.threading.synchronizationcontext)  
[Java Future ExecutorService](https://docs.oracle.com/javase/8/docs/api/java/util/concurrent/ExecutorService.html)  
[JavaScript Promise EventLoop](https://javascript.info/event-loop#macrotasks-and-microtasks)  
Relying on a static execution context is not okay no matter how you approach the thing in question.  
  
## Work in progress.  
Support us at https://www.patreon.com/bananaparty
