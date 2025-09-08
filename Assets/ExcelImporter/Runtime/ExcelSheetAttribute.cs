using System;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
public class ExcelSheetAttribute : Attribute
{
    public string SheetName { get; set; }

    public ExcelSheetAttribute(string sheetName)
    {
        SheetName = sheetName;
    }
}