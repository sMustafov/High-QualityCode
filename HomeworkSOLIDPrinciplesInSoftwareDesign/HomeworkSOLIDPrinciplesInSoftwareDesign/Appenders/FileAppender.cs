namespace HomeworkSOLIDPrinciplesInSoftwareDesign.Appenders
{
    using System;
    using Interfaces;

    public class FileAppender : Appender
    {
        public FileAppender(ILayout layout) 
            : base(layout)
        {
        }

        public string File { get; set; }

        public override void Append(DateTime date, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string formattedLogEntry = this.GetFormattedLogEntry(date, reportLevel, message);

                System.IO.File.AppendAllText(File, formattedLogEntry);
            }
        }
    }
}