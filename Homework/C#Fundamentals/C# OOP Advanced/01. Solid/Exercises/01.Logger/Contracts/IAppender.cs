using System;
using System.Collections.Generic;
using System.Text;

public interface IAppender
{
    ILayout Layout { get; }

    ReportLevel ReportLevel { get; set; }

    void Append(string time, string reportLevel, string message);
}
