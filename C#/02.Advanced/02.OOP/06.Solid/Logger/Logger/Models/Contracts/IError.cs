using System;

using Logger.Models.Enimerations;

namespace Logger.Models.Contracts
{
    public interface IError
    {
        DateTime DateTime { get; }

        string Message { get; }

        Level Level { get; }
    }
}
