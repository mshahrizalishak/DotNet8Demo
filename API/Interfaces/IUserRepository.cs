using System;
using API.DTOs;
using API.Entities;

namespace API.Interfaces;

public interface IUserRepository
{
    void Update(AppUser user);

    Task<bool> SaveAllAsync();
    Task<IEnumerable<AppUser>> GetUserAsync();
    Task<AppUser?> GetUserByIdAsync(int id);
    Task<AppUser?> GetUserByUsernameAync(string username);
    Task<IEnumerable<MemberDto>> GetMembersAsync();
    Task<MemberDto?> GetMemberAsync(string username);
}
