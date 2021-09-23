namespace DesignPattern.Builder
{
    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract ReportBuilder SetReportType();
        public abstract ReportBuilder SetReportHeader();
        public abstract ReportBuilder SetReportContent();
        public abstract ReportBuilder SetReportFooter();
        public ReportBuilder CreateNewReport()
        {
            reportObject = new Report();
            return this;
        }
        public Report GetReport()
        {
            return reportObject;
        }
    }
}
