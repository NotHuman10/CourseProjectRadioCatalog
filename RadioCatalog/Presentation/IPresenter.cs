using System;
using System.Collections.Generic;
using RadioCatalog.LIB;

namespace RadioCatalog
{
    public interface IPresenter
    {
        void Run();
    }

    public interface IMainPresenter : IPresenter
    {
        Dictionary<string, int> Categories { get; }
        Dictionary<int, RadioComponent> Items { get; }
    }
}
