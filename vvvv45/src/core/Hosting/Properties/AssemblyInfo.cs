﻿using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// This sets the default COM visibility of types in the assembly to invisible.
// If you need to expose a type to COM, use [ComVisible(true)] on that type.
[assembly: ComVisible(true)]

[assembly: InternalsVisibleTo("PinTests")]
[assembly: InternalsVisibleTo("StreamTests")]