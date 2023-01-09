using System;
using System.Collections.Generic;
using System.Text;

namespace IdentificationNumber.Interfaces
{
    public interface IIdentificationNumber
    {
        string ToFormalString();
        bool IsValid { get; }
    }
}
