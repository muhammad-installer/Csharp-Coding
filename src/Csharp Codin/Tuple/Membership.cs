public class Membership
    {
        public (AccountCreationStatus, User) CreateUser(string username, string password)
        {
            User newUser = new User() { Username = username, Password = password };
            AccountCreationStatus status = StoreInDatabase(newUser);
            
            return (status, newUser);




        }

        public AccountCreationStatus StoreInDatabase(User user)
        {
            return AccountCreationStatus.Success;

        }








    }

