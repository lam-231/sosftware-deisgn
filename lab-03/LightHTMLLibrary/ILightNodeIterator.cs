using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public interface ILightNodeIterator
    {
        bool HasNext();
        LightNode Next();
        void Reset();
    }
}
