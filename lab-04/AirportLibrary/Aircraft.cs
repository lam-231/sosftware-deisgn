using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportLibrary
{
    public class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }
        private CommandCentre? _mediator;

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void SetMediator(CommandCentre mediator)
        {
            this._mediator = mediator;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is requesting landing.");

            if (_mediator == null)
            {
                Console.WriteLine("No mediator set for aircraft.");
                return;
            }

            if (_mediator.RequestLanding(this))
            {
                Console.WriteLine($"Aircraft {this.Name} has landed.");
            }
            else
            {
                Console.WriteLine($"Could not land, all runways are busy.");
            }
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is taking off.");

            if (_mediator == null)
            {
                Console.WriteLine("No mediator set for aircraft.");
                return;
            }

            IsTakingOff = true;
            _mediator.NotifyTakeOff(this);
            IsTakingOff = false;
            Console.WriteLine($"Aircraft {this.Name} has took off.");
        }
    }
}
