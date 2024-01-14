using Microsoft.AspNetCore.Identity;
using TezAPI.Application.Abstractions.Services;
using TezAPI.Application.DTOs.User;
using TezAPI.Application.DTOs.User.UpdateEmail;
using TezAPI.Application.DTOs.User.UpdatePassword;
using TezAPI.Application.Repositories;
using TezAPI.Domain.Entities;
using TezAPI.Domain.Entities.Identity;

namespace TezAPI.Persistence.Services
{
    public class UserService : IUserService
    {
        readonly UserManager<TezAPI.Domain.Entities.Identity.AppUser> _userManager;
        readonly IAllergyReadRepository _allergyReadRepository;
        readonly ICategoryReadRepository _categoryReadRepository;
        readonly IUserWriteRepository _userWriteRepository;
        public UserService(UserManager<AppUser> userManager,
            IAllergyReadRepository allergyReadRepository,
            ICategoryReadRepository categoryReadRepository,
            IUserWriteRepository userWriteRepository)
        {
            _userManager = userManager;
            _allergyReadRepository = allergyReadRepository;
            _categoryReadRepository = categoryReadRepository;
            _userWriteRepository = userWriteRepository;
        }

        public async Task<CreateUserResponse> CreateAsync(CreateUser model)
        {
            var u = await _userManager.FindByNameAsync(model.UserName);
            var p = await _userManager.FindByEmailAsync(model.Email);
            if(u != null && p != null)
                return new()
                {
                    Succeded = false,
                    Message = "kullanıcı ve email daha önce kullanılımış"
                };
            
            User user = new User()
            {
                Id = Guid.NewGuid()
            };
            if (model.addAllergy.Count > 0)
            {
                foreach (var item in model.addAllergy)
                {
                    Allergy allergy = await _allergyReadRepository.GetByIdAsync(item.Id);
                    if (allergy != null)
<<<<<<< HEAD
                    user.Allergies.Add(allergy);
=======
                    user.UserAllergies.Add(allergy);
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
                }
            }
            if (model.addFavoriteCategories.Count > 0)
            {
                foreach (var item in model.addFavoriteCategories)
                {
                    Category userFavoriteCategory = await _categoryReadRepository.GetByIdAsync(item.Id);
                    if (userFavoriteCategory != null)
                    user.UserFavoriteCategories.Add(userFavoriteCategory);
                }
            }


            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.UserName,
                Email = model.Email,
                NameSurname = model.NameSurname,
                User = user
            }, model.Password);
            
            if (result.Succeeded)
                return new()
                {
                    Succeded = true,
                    Message = "Kullanıcı başarıyla oluştı-urulmuştur"
                };
            else
                return new()
                {
                    Succeded = false,
                    Message = "başarısız"
                };
        }

        public async Task<UpdateEmailResponse> UpdateEmailAsync(string currentEmail, string newEmail)
        {
            var user = await _userManager.FindByEmailAsync(currentEmail);
            if (user == null)
            {
                return new()
                {
                    Message = "User not found",
                    Succeded = false,
                };
            }

            user.Email = newEmail;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return new()
                {
                    Message = "Email updated successfully",
                    Succeded = true,
                };
            }
            else
            {
                return new()
                {
                    Message = "Email is not changed",
                    Succeded = false,
                };
            }
        }

        public async Task<UpdatePasswordResponse> UpdatePasswordAsync(UpdatePasswordRequest model)
        {
            var user = await _userManager.FindByEmailAsync(model.UserNameorEmail);
            if (user == null) 
              user = await _userManager.FindByNameAsync(model.UserNameorEmail);
            if (user == null)
            {
                return new()
                {
                    Message = "User not found",
                    Succeded = false,
                };
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, model.newPassword);

            if (result.Succeeded)
            {
                return new()
                {
                    Message = "Password Changed",
                    Succeded = true,
                };
            }
            else
            {
                return new()
                {
                    Message = "Password is not changed",
                    Succeded = false,
                };
            }

        }

        public async Task<UpdateEmailResponse> UpdateUsernameAsync(string currentEmail, string newEmail)
        {
            var user = await _userManager.FindByNameAsync(currentEmail);
            if (user == null)
            {
                return new()
                {
                    Message = "User not found",
                    Succeded = false,
                };
            }

            user.UserName = newEmail;

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return new()
                {
                    Message = "Username updated successfully",
                    Succeded = true,
                };
            }
            else
            {
                return new()
                {
                    Message = "User Name is not changed",
                    Succeded = false,
                };
            }
        }
        //daha sonra denenecek
        public async Task<UpdateEmailResponse> UpdateAllergyAsync(string UserNameorEmail,string allergyId)
        {
            var user = await _userManager.FindByEmailAsync(UserNameorEmail);
            if (user == null)
                user = await _userManager.FindByNameAsync(UserNameorEmail);
            if (user == null)
            {
                return new()
                {
                    Message = "User not found",
                    Succeded = false,
                };
            }
            Allergy allergy = await _allergyReadRepository.GetByIdAsync(allergyId);
            User userUpdate = user.User;
            if (allergy != null) 
<<<<<<< HEAD
               userUpdate.Allergies.Add(allergy);
=======
               userUpdate.UserAllergies.Add(allergy);
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
             _userWriteRepository.Update(userUpdate);

            var result = await _userWriteRepository.SaveAsync();
            if (result > 0)
            {
                return new()
                {
                    Message = "Allergy added",
                    Succeded = true,
                };
            }
            else
            {
                return new()
                {
                    Message = "Error",
                    Succeded = false,
                };
            }
        }
        public async Task<UpdateEmailResponse> RemoveAllergyAsync(string userId, string allergyId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return new()
                {
                    Message = "User not found",
                    Succeded = false,
                };
            }
            Allergy allergy = await _allergyReadRepository.GetByIdAsync(allergyId);
            User userUpdate = user.User;
            if (allergy != null)
<<<<<<< HEAD
                userUpdate.Allergies.Remove(allergy);
=======
                userUpdate.UserAllergies.Remove(allergy);
>>>>>>> 42e5ef53e9764b27b5e0b0c8d2072b1299e3340f
            _userWriteRepository.Update(userUpdate);

            var result = await _userWriteRepository.SaveAsync();
            if (result > 0)
            {
                return new()
                {
                    Message = "Allergy remove",
                    Succeded = true,
                };
            }
            else
            {
                return new()
                {
                    Message = "Error",
                    Succeded = false,
                };
            }
        }


    }
}
