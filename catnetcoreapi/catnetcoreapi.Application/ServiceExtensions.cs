﻿using AutoMapper;
using catnetcoreapi.Application.Behaviours;
using catnetcoreapi.Application.Helpers;
using catnetcoreapi.Application.Interfaces;
using catnetcoreapi.Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace catnetcoreapi.Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddScoped<IDataShapeHelper<Position>, DataShapeHelper<Position>>();
            services.AddScoped<IDataShapeHelper<Employee>, DataShapeHelper<Employee>>();
            services.AddScoped<IModelHelper, ModelHelper>();
            //services.AddScoped<IMockData, MockData>();
        }
    }
}
