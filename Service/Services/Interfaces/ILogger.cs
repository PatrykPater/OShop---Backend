using System;

namespace Service.Services.Interfaces
{
    public interface ILogger
    {
        void Log(Exception ex);
    }
}