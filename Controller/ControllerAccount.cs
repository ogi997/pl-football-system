using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    public class ControllerAccount
    {
        public string SelectTheme(int userId)
        {
            return WrapperAccount.GetTheme(userId);
        }
        public void UpdateTheme(int userId, int themeId)
        {
            WrapperAccount.UpdateTheme(userId, themeId);
        }
        public void UpdateById(AccountModel ac)
        {
            WrapperAccount.UpdateAccountById(ac);
        }
        public AccountModel FindByUsername(string username)
        {
            return WrapperAccount.SelectByUsername(username);
        }
        public void Insert(AccountModel account)
        {
            WrapperAccount.Insert(account);
        }
        public void UpdateRoleById(int role, int id)
        {
            WrapperAccount.UpdateRoleById(role, id);
        }
        public AccountModel FindAccountById(int id)
        {
            return WrapperAccount.SelectAccountById(id);
        }
        public void UpdateStatusById(int status, int id)
        {
            WrapperAccount.UpdateStatusById(status, id);
        }
        public int? FindStatusById(int id)
        {
            return WrapperAccount.SelectStatus(id);
        }
        public List<AccountModel> FindAll()
        {
            return WrapperAccount.SelectAll();
        }
        public AccountModel FindUserByUsernameAndPassword(string username, string password)
        {
            return WrapperAccount.SelectUserByUsernameAndPassword(username, password);
        }
    }
}
