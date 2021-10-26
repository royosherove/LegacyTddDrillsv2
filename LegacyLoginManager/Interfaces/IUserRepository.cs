using System;

namespace MyBillingProduct
{
    public interface IUserRepository
    {
        DateTime getLastLogin(string userName);
        void SetLastLogin(string user, DateTime dateTime);
    }
}