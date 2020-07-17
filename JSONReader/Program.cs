using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRES.DataContract;

namespace JSONReader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmJSONReader());
        }
        public static string LiborSchedule(NoteDataContract noteDC, DateTime Start, DateTime End)
        {
            string libschedule = string.Empty;
            
            foreach(LiborScheduleTab lib in noteDC.ListLiborScheduleTab)
            {
                if (lib.Date >= Start && lib.Date <= End)
                    libschedule += "\r\n" + lib.Date.ToString() + "\t" + lib.Value.ToString();
            }

            return libschedule;
        }

        public static string FundingSchedule(NoteDataContract noteDC, DateTime? EffDate=null)
        {
            string fundschedule = string.Empty;
            foreach(FutureFundingScheduleTab fundDC in noteDC.ListFutureFundingScheduleTab)
            {
                if (fundDC.EffectiveDate == EffDate)
                    fundschedule += "\r\n" + fundDC.Date.ToString() + ": " + fundDC.Value.ToString();
            }

            return fundschedule;
        }


        public static string RateSpreadSchedule(NoteDataContract noteDC, DateTime? EffDate = null)
        {
            string rsSchedule = EffDate.ToString();

            foreach (RateSpreadSchedule rs in noteDC.RateSpreadScheduleList)
            {
                if (rs.EffectiveDate == EffDate)
                    rsSchedule += "\r\n" + rs.Date.ToString() + ": " + rs.ValueTypeText+ "- " + rs.Value.ToString();
            }

            return rsSchedule;
        }
    }
}
