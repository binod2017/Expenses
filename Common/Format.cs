using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Format
    {
        public static string ConvertIntToMonth(int mth)
        {
            string result = "";
            switch (mth)
            {
                case 1:
                    result = "Jan";
                    break;

                case 2:
                    result = "Feb";
                    break;
                case 3:
                    result = "Mar";
                    break;
                case 4:
                    result = "Apr";
                    break;
                case 5:
                    result = "May";
                    break;
                case 6:
                    result = "Jun";
                    break;
                case 7:
                    result = "Jul";
                    break;
                case 8:
                    result = "Aug";
                    break;
                case 9:
                    result = "Sep";
                    break;
                case 10:
                    result = "Oct";
                    break;
                case 11:
                    result = "Nov";
                    break;
                case 12:
                    result = "Dec";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
