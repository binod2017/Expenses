using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public static class Utilities
{
    /// <summary>
    /// Conversion of integer to Month
    /// </summary>
    /// <param name="mth">intger of the month</param>
    /// <returns>string of the month</returns>
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
    /// <summary>
    /// get the week number from the current date
    /// </summary>
    /// <param name="date">date</param>
    /// <returns>week number</returns>
    public static int GetIso8601WeekNumber(this DateTime date)
    {
        var thursday = date.AddDays(3 - ((int)date.DayOfWeek + 6) % 7);
        return 1 + (thursday.DayOfYear - 1) / 7;
    }
    //public static int GetIso8601WeekOfYear(DateTime date)
    //{
    //    DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
    //    if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
    //    {
    //        date = date.AddDays(3);
    //    }

    //    return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
    //}
    /// <summary>
    /// First day of the week from the week number
    /// </summary>
    /// <param name="year">Year</param>
    /// <param name="weekOfYear">week numberr</param>
    /// <param name="ci">Culture</param>
    /// <returns>First date of the week</returns>
    public static DateTime FirstDateOfWeek(int year, int weekOfYear, System.Globalization.CultureInfo ci)
    {
        DateTime jan1 = new DateTime(year, 1, 1);
        int daysOffset = (int)ci.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;
        DateTime firstWeekDay = jan1.AddDays(daysOffset);
        int firstWeek = ci.Calendar.GetWeekOfYear(jan1, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
        if ((firstWeek <= 1 || firstWeek >= 52) && daysOffset >= -3)
        {
            weekOfYear -= 1;
        }
        return firstWeekDay.AddDays(weekOfYear * 7);
    }
    /// <summary>
    /// Last day of the week from the First day of the week
    /// </summary>
    /// <param name="firstdateofweek">First date of the week</param>
    /// <returns>Last date of the week</returns>
    public static DateTime LastDateOfWeek(DateTime firstdateofweek)
    {
        return firstdateofweek.AddDays(6);
    }
    /// <summary>
    /// Save it to Google Drive
    /// </summary>
    /// <param name="allfiles"></param>
    /// <returns></returns>
    public static bool SaveItToGoogleDrive(string[] allfiles)
    {
        bool flag = true;
        foreach (var filename in allfiles)
        {
            flag = StoreinGoogle(filename);
        }
        return flag;
    }
    /// <summary>
    /// Save it to Database Backup
    /// </summary>
    /// <param name="allfiles"></param>
    /// <returns></returns>
    public static bool SaveItToDbBackup(string[] allfiles)
    {
        bool flag = true;
        foreach (var filename in allfiles)
        {
            flag = StoreinBackup(filename);
        }
        return flag;
    }
    public static bool StoreinGoogle(string filename)
    {
        bool flag = true;
        //Source path must be the bin folder(Release and Debug)
        string sourcepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //Target path must be from google drive
        //string targetpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"Google Drive\");
        string targetpath = System.Configuration.ConfigurationManager.AppSettings["SourcePath"];
        return flag = UpdateDatabase(sourcepath, targetpath, filename);
    }
    public static bool StoreinBackup(string filename)
    {
        bool flag = true;
        //Source path must be the bin folder(Release and Debug)
        string sourcepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        //Target path must be from google drive
        //string targetpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"E:\DatabaseBackup\");
        string targetpath = System.Configuration.ConfigurationManager.AppSettings["TargetPath"];
        return flag = UpdateDatabase(sourcepath, targetpath, filename);
    }
    /// <summary>
    /// Restore it from Google Drive
    /// </summary>
    /// <param name="allfiles"></param>
    /// <returns></returns>
    public static bool RestoreItFromGoogleDrive(string[] allfiles)
    {
        bool flag = true;
        foreach (var filename in allfiles)
        {
            //Source path must be from google drive
            //string sourcepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"Google Drive\");
            string sourcepath = System.Configuration.ConfigurationManager.AppSettings["SourcePath"];
            //Target path must be the bin folder(Release and Debug)
            string targetpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            bool result = UpdateDatabase(sourcepath, targetpath, filename);
        }
        return flag;
    }
    /// <summary>
    /// Restore it from Database backup
    /// </summary>
    /// <param name="allfiles"></param>
    /// <returns></returns>
    public static bool RestoreItFromDBBackup(string[] allfiles)
    {
        bool flag = true;
        foreach (var filename in allfiles)
        {
            //Source path must be from google drive
            //string sourcepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"E:\DatabaseBackup\");
            string sourcepath = System.Configuration.ConfigurationManager.AppSettings["TargetPath"];
            //Target path must be the bin folder(Release and Debug)
            string targetpath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            bool result = UpdateDatabase(sourcepath, targetpath, filename);
        }
        return flag;
    }
    /// <summary>
    /// Update the strorage
    /// </summary>
    /// <param name="sourcepath"></param>
    /// <param name="targetpath"></param>
    /// <param name="filename"></param>
    /// <returns></returns>
    public static bool UpdateDatabase(string sourcepath, string targetpath, string filename)
    {
        bool flag = true;
        try
        {
            string sourceFile = Path.Combine(sourcepath, filename);
            string destFile = Path.Combine(targetpath, filename);
            File.Copy(sourceFile, destFile, true);
        }
        catch (Exception)
        {
            throw;
        }
        return flag;
    }
    /// <summary>
    /// Check for the internet connection to update the local Google drive
    /// </summary>
    /// <returns></returns>
    public static bool CheckForInternetConnection()
    {
        try
        {
            using (var client = new WebClient())
            {
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
        }
        catch
        {
            return false;
        }
    }
}

