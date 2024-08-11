﻿using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;
    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }
    public Task<IEnumerable<UserModel>> GetUsers() =>
  _db.LoadData<UserModel, dynamic>(storedProcedure: "Sp_UserGetAll", new { });
    public async Task<UserModel?> GetUser(int id)
    {
        var results = await _db.LoadData<UserModel, dynamic>(storedProcedure: "dbo.sp_UserGet", new { Id = id });
        return results.FirstOrDefault();
    }
    public Task InsertUser(UserModel user) =>
       _db.SaveDate(storedProcedure: "dbo.spUser_Insert", new { user.FirstName, user.LastName });

    public Task UpdateUser(UserModel user) =>
        _db.SaveDate(storedProcedure: "spUser_Update", user);

    public Task DeleteUser(int id) =>
        _db.SaveDate(storedProcedure: "sPUser_Delete", new { Id = id });
}

