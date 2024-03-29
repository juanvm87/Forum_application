﻿using Domain.DTOs;
using Domain.Models;

namespace Application.DAOInterface;

public interface IUserDao
{
    Task<User> CreateAsync(User user);
    Task<User?> GetByUsernameAsync(string userName);
    Task<IEnumerable<User>> GetAsync(SearchUserParametersDto parametersDto);
}