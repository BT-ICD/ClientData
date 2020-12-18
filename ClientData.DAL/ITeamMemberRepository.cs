using System;
using System.Collections.Generic;
using System.Text;
using ClientData.Models;
namespace ClientData.DAL
{
    public interface ITeamMemberRepository
    {
        public List<TeamMemberDTO> List();
        public TeamMemberDTODetail GetById(int id);
        public TeamMemberDTODetail Add(TeamMemberDTODetailAdd teamMemberDTODetail);

        public TeamMemberDTODetail Edit(TeamMemberDTODetail teamMemberDTODetail);

        public TeamMemberDTODelete Delete(int id);

    }
}
