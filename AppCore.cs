using System;
namespace cmd1
{
    public class AppCore
    {
        DateTime selectDate;

        // default path to inf
        const string base_path = "~/site_base/";

        /// <summary>
        /// Default constructor
        /// </summary>
        public AppCore()
        {
            selectDate = new DateTime();
        }

        /// <summary>
        /// Add new html function
        /// </summary>
        public void AddNewHtml(string html)
        {

        }

        public bool SetDate(string strDate)
        {
            DateTime date = new DateTime();
            string msg;

            bool bRes = DateTime.TryParse(strDate, out date);
            if (false == bRes)
            {
                msg = "date or date format error";
            }
            else
            {
                msg = date.ToString("yyyy-MM-dd");
                selectDate = date;
            }
            Console.WriteLine(msg);

            return bRes;

        }

        public void ReadHtmlsFromDisk(DateTime date, string city_prefix)
        {

        }
    }
}
