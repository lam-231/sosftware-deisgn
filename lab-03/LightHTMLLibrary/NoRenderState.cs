using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public class NoRenderState : IRenderState
    {
        public string Render(LightElementNode element)
        {
            return string.Empty;
        }
    }
}
