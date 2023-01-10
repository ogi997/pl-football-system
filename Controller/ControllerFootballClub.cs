using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerFootballClub
    {
        public void UpdateByClubId(FootballClubModel fc)
        {
            WrapperFootballClub.UpdateByClubId(fc);
        }
        public FootballClubModel FindByClubId(int clubId)
        {
            return WrapperFootballClub.SelectClubById(clubId);
        }
        public void DeleteByClubId(int footballClubId)
        {
            WrapperFootballClub.DeleteById(footballClubId);
        }
        public List<FootballClubModel> FindAll()
        {
            return WrapperFootballClub.SelectAll();
        }
        public void InsertFC(FootballClubModel fc)
        {
            WrapperFootballClub.Insert(fc);
        }
    }
}
