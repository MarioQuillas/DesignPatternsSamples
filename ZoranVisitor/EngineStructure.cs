namespace ZoranVisitor
{
    internal class EngineStructure
    {
        public EngineStructure(float power, float cylinderVolume)
        {
            Power = power;
            CylinderVolume = cylinderVolume;
        }

        public float Power { get; }
        public float CylinderVolume { get; }
    }
}