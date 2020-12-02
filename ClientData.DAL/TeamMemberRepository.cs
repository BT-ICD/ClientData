using ClientData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientData.DAL
{
    public class TeamMemberRepository : ITeamMemberRepository
    {
        private readonly ClientDataDbContext _context;
        public TeamMemberRepository(ClientDataDbContext context)
        {
            _context = context;
        }
        public TeamMemberDTODetail Add(TeamMemberDTODetail teamMemberDTODetail)
        {
            var result = _context.TeamMemberDTODetail.FromSqlRaw("Exec TeamMember_Insert {0},{1},{2},{3},{4},{5}", teamMemberDTODetail.Name, teamMemberDTODetail.Email, teamMemberDTODetail.Mobile, teamMemberDTODetail.AlternateContact, teamMemberDTODetail.DOJ, teamMemberDTODetail.Notes).ToList().FirstOrDefault();
            return result;
        }

        public TeamMemberDTODelete Delete(int id)
        {
            var result = _context.TeamMemberDTODelete.FromSqlRaw("Exec TeamMember_Delete {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public TeamMemberDTODetail Edit(TeamMemberDTODetail teamMemberDTODetail)
        {
            var result = _context.TeamMemberDTODetail.FromSqlRaw("Exec TeamMember_Edit {0},{1},{2},{3},{4},{5},{6}", teamMemberDTODetail.TeamMemberId, teamMemberDTODetail.Name, teamMemberDTODetail.Email, teamMemberDTODetail.Mobile, teamMemberDTODetail.AlternateContact, teamMemberDTODetail.DOJ, teamMemberDTODetail.Notes).ToList().FirstOrDefault();
            return result;
        }

        public TeamMemberDTODetail GetById(int id)
        {
            var result = _context.TeamMemberDTODetail.FromSqlRaw("Exec TeamMember_GetById {0}", id).ToList().FirstOrDefault();
            return result;
        }

        public List<TeamMemberDTO> List()
        {
            var result = _context.TeamMemberDTO.FromSqlRaw("Exec TeamMember_List").ToList();
            return result;
        }
    }
}
