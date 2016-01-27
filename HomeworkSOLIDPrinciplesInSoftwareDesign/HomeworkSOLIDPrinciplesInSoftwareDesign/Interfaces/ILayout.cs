namespace HomeworkSOLIDPrinciplesInSoftwareDesign.Interfaces
{
    using System;

    public interface ILayout
    {
        string FormatLog(DateTime date, ReportLevel reportLevel, string message); 
    }
}