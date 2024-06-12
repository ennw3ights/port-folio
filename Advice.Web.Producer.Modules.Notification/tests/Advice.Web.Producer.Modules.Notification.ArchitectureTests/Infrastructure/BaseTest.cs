namespace Advice.Web.Producer.Modules.Notification.ArchitectureTests.Infrastructure;

public abstract class BaseTest
{
    protected static readonly Assembly ModelsAssembly = Models.AssemblyReference.ModelsAssembly;
    protected static readonly Assembly ServicesAssembly = Services.AssemblyReference.ServicesAssembly;
    protected static readonly Assembly ModuleAssembly = WebAppModule.AssemblyReference.ModuleAssembly;
}