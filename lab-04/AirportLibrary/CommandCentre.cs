namespace AirportLibrary
{
    public class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private Dictionary<Runway, Aircraft> _runwayAssignments = new Dictionary<Runway, Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);

            foreach (var runway in _runways)
            {
                runway.SetMediator(this);
            }

            foreach (var aircraft in _aircrafts)
            {
                aircraft.SetMediator(this);
            }
        }

        public bool RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (!_runwayAssignments.ContainsKey(runway))
                {
                    _runwayAssignments[runway] = aircraft;
                    runway.HighLightRed();
                    return true;
                }
            }
            return false;
        }

        public void NotifyTakeOff(Aircraft aircraft)
        {
            foreach (var entry in _runwayAssignments)
            {
                if (entry.Value == aircraft)
                {
                    entry.Key.HighLightGreen();
                    _runwayAssignments.Remove(entry.Key);
                    break;
                }
            }
        }

        public bool IsRunwayBusy(Runway runway)
        {
            return _runwayAssignments.ContainsKey(runway);
        }
    }
}
