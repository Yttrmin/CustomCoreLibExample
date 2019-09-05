# CustomCoreLibExample
This repo contains two projects. One is a custom CoreLib, which defines built-in types like `Object`, `ValueType`, `Void`, etc. The other is a library that consumes the first project in place of the standard CoreLib.

This is a fairly barebones example but includes a few odd "features" just to test out the capabilities:
* Non-static classes can not be defined because `Object`'s default constructor is `internal`.
* `string` has an implicit cast to `int`.
* `Object` contains only a couple nonsense methods instead of what would be expected.

The `.csproj` files are the key to getting it to work. I also had to add a couple types because of the auto-generated `AssemblyAttributes` file. The rest is basically just defining the built-in types as you see fit.

This builds solely through Visual Studio 2019. I have not tried a command line build.

I have not tried executing the assemblies produced by this, as that's not my use case.
