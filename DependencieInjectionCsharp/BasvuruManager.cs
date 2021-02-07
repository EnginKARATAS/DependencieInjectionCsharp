using System;
using System.Collections.Generic;
using System.Text;

namespace DependencieInjectionCsharp
{
    public class BasvuruManager
    {
        public void BasvuruYap(ICreditManager kredi)
        {
            kredi.BasvuruYap();
        }
    }
}
