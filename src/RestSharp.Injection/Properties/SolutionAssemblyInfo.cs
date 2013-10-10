using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyCompany("The Tribe")]
[assembly: AssemblyProduct("RestSharp.Injection")]
[assembly: AssemblyCopyright("Copyright © The Tribe 2013")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion("1.1.0")]

// semver.org tells us to use major.minor.patch[-label[.build]] (e.g. 0.1.3-beta.2),
// but nuget.org requires major.minor.patch[-label[build]] (e.g. 0.1.3-beta2)
// more info: http://docs.nuget.org/docs/reference/versioning
[assembly: AssemblyInformationalVersion("1.1.0-beta1")]