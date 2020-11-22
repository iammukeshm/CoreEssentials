using CoreEssentials.ToastNotify.Enums;

namespace CoreEssentials.ToastNotify.Models
{
    public class Notification
    {
        public Notification(NotificationType type, string message, int? durationInSeconds)
        {
            Message = message;
            Type = type;
            Duration = (durationInSeconds == null || durationInSeconds == 0) ? null : durationInSeconds * 1000;
        }
        public string Message { get; set; }
        public string BackgroundColor { get; set; }
        public string Icon { get; set; }
        public NotificationType Type { get; set; }
        public int? Duration { get; set; }
    }
}
