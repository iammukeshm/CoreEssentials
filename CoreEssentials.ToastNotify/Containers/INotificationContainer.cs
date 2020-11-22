using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Containers
{
    public interface INotificationContainer<TMessage> where TMessage : class
    {
        void Add(TMessage message);
        void RemoveAll();
        IList<TMessage> GetAll();
        IList<TMessage> ReadAll();
    }
}
