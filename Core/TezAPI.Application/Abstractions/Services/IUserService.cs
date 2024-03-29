﻿using TezAPI.Application.DTOs.User;
using TezAPI.Application.DTOs.User.UpdateEmail;
using TezAPI.Application.DTOs.User.UpdatePassword;
using TezAPI.Domain.Entities.Identity;

namespace TezAPI.Application.Abstractions.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser model);
        Task<UpdateEmailResponse> UpdateEmailAsync(string currentEmail, string newEmail);
        Task<UpdateEmailResponse> UpdateUsernameAsync(string currentEmail,string newEmail);
        Task<UpdatePasswordResponse> UpdatePasswordAsync(UpdatePasswordRequest model);
    }
}
