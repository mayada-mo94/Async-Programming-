using System.Collections.Generic;

namespace DesignPattern.Mediator
{
    public class ConcreteFacebookGroupMediator : FacebookGroupMediator
    {
        private List<User> usersList = new List<User>();
        public void RegisterUsers(List<User> users)
        {
            usersList = users;
        }
        public void SendMessage(string message, User user)
        {
            foreach (var u in usersList)
            {
                // message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
