# A-002 Koivos.NET   

### Introduction

A lot of times in PITG we encounter students asking what's wrong in their code.
How about making a template they can use as a guide on how to use commonly-used controls 
and a reusable class library that can be utilized on problems and scenarios given in the academe or at work.

### Goals

* Object-oriented
* Properly documented (in both English and Filipino)
* Compatibility across versions of Visual Studio
* Compatibility across versions of .NET Framework

### Directory Structure

There will be two main directories - Common and Examples. Reusable class libraries will be located in Common
while implementation to demonstrate the usage of it will be in the Examples folder.

Under each directory will have a sub-folder named after what version of Visual Studio it is made.
```
FORMAT: /Common/src/{vs_version}/ | /Examples/{example_number}
```

Example:
```
/Common/src/2012/Common.sln
/Common/src/2010/Common.sln

/Examples/001-LoginForm/2012/LoginForm.sln
/Examples/001-LoginForm/2010/LoginForm.sln
```

In terms of .NET framework, the following directory structure should be followed for the binaries:
```
FORMAT: /Common/bin/{framework_version}
```

Example:
```
/Common/bin/2.0
/Common/bin/3.5
/Common/bin/4.0
```

### C.C.

* Developers for VB.NET and C#
* Testers

### Mentors
* \[A-002\] : [kimerran] (http://markhughneri.com)
