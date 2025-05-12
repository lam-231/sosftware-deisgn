using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLibrary
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        private CommandCentre? _mediator;

        public void SetMediator(CommandCentre mediator)
        {
            this._mediator = mediator;
        }

        public bool CheckIsActive()
        {
            return _mediator?.IsRunwayBusy(this) ?? false;
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }
}
