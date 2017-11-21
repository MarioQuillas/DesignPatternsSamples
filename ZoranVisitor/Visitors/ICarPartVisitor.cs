﻿namespace ZoranVisitor.Visitors
{
    internal interface ICarPartVisitor
    {
        void VisitEngine(EngineStructure structure, EngineStatus status);
        void VisitSeat(string name, int capacity);
    }
}