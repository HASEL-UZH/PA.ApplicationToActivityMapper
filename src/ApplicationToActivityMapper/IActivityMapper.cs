namespace ApplicationToActivityMapper
{
    public interface IActivityMapper
    {
        /// <summary>
        /// Map a windowsactivity-entry (given process and window name) to 
        /// an activity category.
        /// </summary>
        /// <param name="processName"></param>
        /// <param name="window"></param>
        /// <returns></returns>
        ActivityCategory Map(string processName, string window);
    }
}