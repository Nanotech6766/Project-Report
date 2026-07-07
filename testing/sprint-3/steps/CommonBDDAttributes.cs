using System;

namespace foll_backend.Tests.Steps;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class GivenAttribute : Attribute
{
    public GivenAttribute(string pattern) { Pattern = pattern; }
    public string Pattern { get; }
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class WhenAttribute : Attribute
{
    public WhenAttribute(string pattern) { Pattern = pattern; }
    public string Pattern { get; }
}

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class ThenAttribute : Attribute
{
    public ThenAttribute(string pattern) { Pattern = pattern; }
    public string Pattern { get; }
}
