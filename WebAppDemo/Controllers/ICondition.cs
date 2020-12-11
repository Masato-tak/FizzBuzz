using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppDemo.Controllers
{
    public interface ICondition
    {
        bool Matches(string input);

        string GetMessage();
    }
}
