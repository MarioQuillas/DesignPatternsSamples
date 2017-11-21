using System;
using ZoranVisitor.Visitors;

namespace ZoranVisitor
{
    internal class Engine
    {
        private const float WorkingTemperatureC = 90.0F;
        private readonly float cylinderVolume;

        private readonly float power;
        private float temperatureC = 20.0F;

        public Engine(float power, float cylinderVolume)
        {
            this.power = power;
            this.cylinderVolume = cylinderVolume;
        }

        public void Accept(Func<ICarPartVisitor> visitorFactory)
        {
            var structure = new EngineStructure(power, cylinderVolume);
            var status = new EngineStatus(temperatureC, 0);
            visitorFactory().VisitEngine(structure, status);
        }

        public void Run(TimeSpan time)
        {
            var heatingTime = GetHeatingTime();

            if (time > heatingTime)
            {
                temperatureC = WorkingTemperatureC;
            }
            else
            {
                double temperatureDelta = WorkingTemperatureC - temperatureC;
                var timeRatio = time.TotalMinutes / heatingTime.TotalMinutes;
                temperatureC += (float) (temperatureDelta * timeRatio);
            }
        }

        private TimeSpan GetHeatingTime()
        {
            var meanPower = 180.0;
            var nominalHeatingTimeSec = 300.0;

            var seconds = (int) (nominalHeatingTimeSec * meanPower / power);

            return new TimeSpan(0, 0, seconds);
        }
    }
}