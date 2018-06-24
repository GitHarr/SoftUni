namespace Travel.Entities.Factories
{
	using Contracts;
	using Airplanes.Contracts;
    using Travel.Entities.Airplanes;
    using System;
    using System.Reflection;
    using System.Linq;

    public class AirplaneFactory : IAirplaneFactory
	{
		public IAirplane CreateAirplane(string type)
		{
            var airplaneType = Assembly.GetCallingAssembly().GetTypes()
                .Where(t => typeof(IAirplane).IsAssignableFrom(t))
                .FirstOrDefault(t => t.Name == type);

            var airplane = (IAirplane)Activator.CreateInstance(airplaneType);

            return airplane;
        }
	}
}