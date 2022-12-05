namespace APIActivite3.Utils
{
    public interface ICurrentUserUtils
    {
        /// <summary>
        /// To Get the Current User Id
        /// </summary>
        /// <returns>Id or null</returns>
        public int? GetCurrentUserId();
        public bool IsModerator();
    }
}