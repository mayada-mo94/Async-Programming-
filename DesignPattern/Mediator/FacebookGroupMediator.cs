using System.Collections.Generic;

namespace DesignPattern.Mediator
{
    public interface FacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUsers(List<User> users);
    }
}
