using System;
using System.Collections;

namespace MyBillingProduct
{
	public class UserData
	{
		public string Username { get; set; }
		public string Password { get; set; }
		
	}
	public class LoginManagerWithTime
	{
		private readonly IUserRepository _repository;

		public LoginManagerWithTime(IUserRepository repository)
		{
			_repository = repository;
		}
	    private Hashtable m_users = new Hashtable();

	    public bool IsLoginOK(UserData data)
	    {
			if ((DateTime.Now - _repository.getLastLogin(data.Username)).Days>180)
			{
				new RealLogger().Write("User last login too old");
				return false;
			}
			_repository.SetLastLogin(data.Username,DateTime.Now);
	        return m_users[data.Username] != null &&
	               (string) m_users[data.Username] == data.Password;
	    }
	    

	    public void AddUser(string user, string password)
	    {
	        m_users[user] = password;
	    }

	    public void ChangePass(string user, string oldPass, string newPassword)
		{
			m_users[user]= newPassword;
		}
	}
}
