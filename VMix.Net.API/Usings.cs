﻿global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;
global using VMix.Data.Context;
global using VMix.Services.Concretes;
global using VMix.Services.Abstractions;
global using VMix.CQRS.Contracts;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Storage;
global using VMix.CQRS.CommandRequests;
global using Microsoft.Extensions.Logging;
global using VMix.Data.Entities;
global using WatchDog;
global using WatchDog.src.Enums;
global using VMix.Net.API.Extensions;
global using Microsoft.OpenApi.Models;
global using System.Reflection;
global using Microsoft.AspNetCore.Mvc.Versioning;
global using System.Security.Cryptography;
global using System.Text;
global using Microsoft.Extensions.Configuration;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using System.Configuration;
global using Microsoft.IdentityModel.Tokens;
global using Microsoft.AspNetCore.Authorization;
global using VMix.CQRS.Contracts.UserContracts;
global using VMix.Net.API.Middlewares;
global using VMix.Data.Middleware;
global using System.Security.Claims;