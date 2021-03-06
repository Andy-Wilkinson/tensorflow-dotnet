using System;

[System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
sealed class PythonClassAttribute : Attribute
{
    public PythonClassAttribute(string className)
    {
        this.ClassName = className;
    }

    public string ClassName
    {
        get;
    }

    public string File
    {
        get;
        set;
    }

    public bool GenerateMethods
    {
        get;
        set;
    }
}