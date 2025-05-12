using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightHTMLLibrary
{
    public class PreviewRenderState : IRenderState
    {
        public string Render(LightElementNode element)
        {
            return $"<preview>{element.TagName}</preview>";
        }
    }
}
