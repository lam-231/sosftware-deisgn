using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public interface IRenderState
    {
        string Render(LightElementNode element);
    }
}
