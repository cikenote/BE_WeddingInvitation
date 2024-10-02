﻿using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
namespace Wedding.API.Extentions;

public static class WebApplicationBuilderExtensions
{
    public static WebApplicationBuilder AddAppAuthentication(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthentication(options =>
        {
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.SaveToken = true;
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
                ValidAudience = builder.Configuration["JWT:ValidAudience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
            };
        });

        return builder;
    }

    public static WebApplicationBuilder AddSwaggerGen(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition(name: "Bearer", securityScheme: new OpenApiSecurityScheme()
            {
                Name = "Authorization",
                In = Microsoft.OpenApi.Models.ParameterLocation.Header,
                Description = "Please enter your token with this format: \"Bearer YOUR_TOKEN\"",
                Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
                BearerFormat = "JWT",
                Scheme = "bearer"
            });
            options.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme()
                    {
                        Name = "Bearer",
                        In = ParameterLocation.Header,
                        Reference = new OpenApiReference()
                        {
                            Id = "Bearer",
                            Type = ReferenceType.SecurityScheme
                        }
                    },
                    new List<string>()
                }
            });
        });

        return builder;
    }
}