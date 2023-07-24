public class MyClass : IDisposable
{
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }


}