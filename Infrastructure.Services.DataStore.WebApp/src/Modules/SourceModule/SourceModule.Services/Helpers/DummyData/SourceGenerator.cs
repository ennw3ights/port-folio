namespace SourceModule.Services.Helpers.DummyData;

public static class SourceGenerator
{
    public static List<SourceDto> GenerateSourceDtos()
    {
        var dummyDtos = new List<SourceDto>();

        for (int i = 0; i < 30; i++)
        {
            dummyDtos.Add(new()
            {
                Id = "1",
                Name = "name" + i,
                Type = SourceType.ManualLoading,
                DateTimeCreate = DateTime.SpecifyKind(DateTime.Now.AddDays(i), DateTimeKind.Local),
                DateTimeModified = DateTime.SpecifyKind(DateTime.Now.AddDays(i), DateTimeKind.Local),
                Template = new SourceTemplate()
            });
        }

        return dummyDtos;
    }
}
