﻿using System;
using System.Collections.Generic;

namespace DI
{
    public interface IDependencyInjectionContainer
    {
        object GetInstance(Type type);
        IEnumerable<object> GetAllInstances(Type type);
    }

    public static class DependencyInjectionContainerExtensions
    {
        public static T GetInstance<T>(this IDependencyInjectionContainer container)
        {
            return (T)container.GetInstance(typeof(T));
        }
    }
}