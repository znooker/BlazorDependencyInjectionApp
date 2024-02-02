namespace Application.Services;

public interface ITestService
{
    public string Name { get; set; }
    public Task<string> PrintName();
}
