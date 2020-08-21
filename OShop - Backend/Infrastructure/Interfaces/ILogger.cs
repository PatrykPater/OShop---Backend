using System;

namespace OShop___Backend.Infrastructure
{
    public interface ILogger
    {
        void Log(Exception ex);
    }
}