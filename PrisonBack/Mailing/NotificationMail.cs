using PrisonBack.Domain.Repositories;

namespace PrisonBack.Mailing
{
    public class NotificationMail : INotificationMail
    {
        private readonly INotificationRepository _notificationRepository;
        public NotificationMail(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }
       
        public string Body(string userName)
        {
            string test = "Lista więźniów którzy wychodzą w ciągu najbliższych dni: <br /> ";
            foreach (var item in _notificationRepository.ListOfPrisoner(1))
            {     
                test += item.Forname + " ";
                test += item.Name + " <br /> ";
            }
            return test;
        }
        public string Title()
        {
            return "Notyfikacja";
        }
        public string To(string email)
        {
            return email;
        }
    }
}
