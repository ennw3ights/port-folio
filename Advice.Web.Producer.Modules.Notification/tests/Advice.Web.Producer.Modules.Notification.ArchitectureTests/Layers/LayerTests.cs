namespace Advice.Web.Producer.Modules.Notification.ArchitectureTests.Layers;

public class LayerTests : BaseTest
{
    [Fact]
    public void ModelsLayerShouldNotHaveDependencyOnServicesLayer()
    {
        TestResult result = Types.InAssembly(ModelsAssembly)
            .Should()
            .NotHaveDependencyOn(ServicesAssembly.GetName().Name)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void ModelsLayerShouldNotHaveDependencyOnModuleLayer()
    {
        TestResult result = Types.InAssembly(ModelsAssembly)
            .Should()
            .NotHaveDependencyOn(ModuleAssembly.GetName().Name)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
    
    [Fact]
    public void ServicesLayerShouldNotHaveDependencyOnModuleLayer()
    {
        TestResult result = Types.InAssembly(ServicesAssembly)
            .Should()
            .NotHaveDependencyOn(ModuleAssembly.GetName().Name)
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}