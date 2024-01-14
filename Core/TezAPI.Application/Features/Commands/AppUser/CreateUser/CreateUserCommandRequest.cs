﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TezAPI.Application.DTOs;
using TezAPI.Application.DTOs.User;

namespace TezAPI.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public List<AddAllergy> addAllergy { get; set; } = new List<AddAllergy>();
        public List<AddFavoriteCategories> addFavoriteCategories { get; set; } = new List<AddFavoriteCategories>();

    }
}
