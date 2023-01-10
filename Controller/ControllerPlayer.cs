using PLFootballSystem.Model;
using PLFootballSystem.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLFootballSystem.Controller
{
    class ControllerPlayer
    {
        public void UpdatePlayerById(PlayerModel player)
        {
            WrapperPlayer.UpdateByPlayerId(player);
        }
        public int? FindStatusById(int id)
        {
            return WrapperPlayer.SelectStatus(id);
        }
        public void UpdateStatusByID(int status, int id)
        {
            WrapperPlayer.UpdateStatusById(status, id);
        }
        public List<PlayerModel> FindAll()
        {
            return WrapperPlayer.SelectAll();
        }
        public PlayerModel FindByPlayerId(int playerId)
        {
            return WrapperPlayer.SelectByPlayerId(playerId);
        }
        public List<PlayerModel> FindByClubId(int clubId)
        {
            return WrapperPlayer.SelectByClubId(clubId);
        } 
        public void InsertPlayer(PlayerModel playerModel)
        {
            WrapperPlayer.InsertPlayer(playerModel);
        }
    }
}
