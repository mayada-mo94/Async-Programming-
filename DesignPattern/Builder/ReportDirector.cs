namespace DesignPattern.Builder
{
    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport()
                .SetReportType()
                .SetReportHeader()
                .SetReportContent()
                .SetReportFooter();

            return reportBuilder.GetReport();
        }
    }
}
