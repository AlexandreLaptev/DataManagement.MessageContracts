namespace DataManagement.MessageContracts
{
    /// <summary>
    /// Defines statuses for the database update progress.
    /// </summary>
    public enum ProgressStatus
    {
        /// <summary>
        /// Status not specified.
        /// </summary>
        None = 0,

        /// <summary>
        /// Status indicating that database update is not required.
        /// </summary>
        NotRequired = 1,

        /// <summary>
        /// Status indicating that database update is processing.
        /// </summary>
        Processing = 2,

        /// <summary>
        /// Status indicating that the database update has been completed successfully.
        /// </summary>
        Completed = 3,

        /// <summary>
        /// Status indicating that process of updating database has been cancelled.
        /// </summary>
        Cancelled = 4,

        /// <summary>
        /// Status indicating that the error occurs during database update processing.
        /// </summary>
        Error = 5
    }
}