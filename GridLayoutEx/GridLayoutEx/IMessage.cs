using System;
using System.Collections.Generic;
using System.Text;

namespace GridLayoutEx
{
    public interface IMessage
    {
        void Longtime(string message);
        void Shorttime(string message);
    }
}
