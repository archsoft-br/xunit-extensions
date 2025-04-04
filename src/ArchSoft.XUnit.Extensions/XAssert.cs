using Xunit;
using Xunit.Sdk;

namespace ArchSoft.XUnit.Extensions;

public static class XAssert
{
    public static void DoesNotThrow(Action action)
    {
        var exception = Record.Exception(action);


        if (exception != null) throw new XunitException("Expected no exception, but got: " + exception.Message);
    }

    public static async Task DoesNotThrowAsync(Func<Task> action)
    {
        var exception = await Record.ExceptionAsync(action);

        if (exception != null) throw new XunitException("Expected no exception, but got: " + exception.Message);
    }
}