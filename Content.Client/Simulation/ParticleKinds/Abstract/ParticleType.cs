﻿namespace Content.Client.Simulation.ParticleKinds.Abstract;

public enum ParticleType: ushort
{
    None = 0,
    Sand,
    Wall,
    Spawner,
    Water,
    Acid,
    Void,
    Fire,
    Smoke,
    Wood,
    Coal,
    Gas,
    Fog,
    Oil,
    
    
    // DO NOT PLACE ANY PARTICLE TYPES AFTER THIS POINT.
    End,
}