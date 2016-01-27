namespace HomeworkSOLIDPrinciplesInSoftwareDesign.Layouts
{
    using Interfaces;
    using System;

    public class SimpleLayout : ILayout
    {
        public string FormatLog(DateTime date, ReportLevel reportLevel, string message)
        {
            string formattedLog = string.Format("{0} - {1} - {2}" + Environment.NewLine, date, reportLevel, message);

            return formattedLog;
        } 
    }
}