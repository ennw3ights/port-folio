using System.Reflection;

namespace Advice.Web.Producer.Modules.Finance.Module;

public static class AssemblyReference
{
    public static readonly Assembly ModuleAssembly = typeof(AssemblyReference).Assembly;
}