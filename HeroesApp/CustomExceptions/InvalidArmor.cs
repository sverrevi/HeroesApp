using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidArmor : Exception
{
    public InvalidArmor()
    {
    }

    public InvalidArmor(string message)
        : base(message)
    {
    }

    public InvalidArmor(string message, Exception inner)
        : base(message, inner)
    {
    }
}