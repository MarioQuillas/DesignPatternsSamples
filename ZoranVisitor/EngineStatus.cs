namespace ZoranVisitor
{
    internal class EngineStatus
    {
        public EngineStatus(float temperatureC, float oilPressure)
        {
            TemperatureC = temperatureC;
            OilPressure = oilPressure;
        }

        public float TemperatureC { get; }
        public float OilPressure { get; }
    }
}