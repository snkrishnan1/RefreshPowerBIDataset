using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerBIEmbedded_AppOwnsData.Models
{
    public class ReportDetails
    {
        public string ReportID { get; set; }

        public string ReportName { get; set; }

        public string DatasetID { get; set; }

        public string LastRefreshDate { get; set; }

        public string EmbedURL { get; set; }

        public string WebUrl { get; set; }
    }
}