﻿using Robust.Shared.Maths;

namespace Content.Client.Simulation.ParticleKinds.Abstract;

public abstract class ParticleImplementation
{
    /// <summary>
    /// The type of the particle. No duplicates, new particles need a new type, one implementation per type.
    /// </summary>
    public abstract ParticleType Type { get; }
    
    /// <summary>
    /// The name of the particle.
    /// </summary>
    public abstract string Name { get; }
    
    /// <summary>
    /// The description of the particle.
    /// </summary>
    public abstract string Description { get; }

    /// <summary>
    /// Controls whether a particle sinks or not through another particle.
    /// Higher values sink through lower values by default.
    /// </summary>
    public abstract byte Weight { get; }

    /// <summary>
    /// The color of the particle.
    /// </summary>
    public abstract Color Color { get; }

    /// <summary>
    /// The rate of gravitational pull (to the floor) for the particle.
    /// </summary>
    public virtual float RateOfGravity { get; } = 0.05f;

    public abstract ParticleMovementProperty MovementProperties { get; }

    /// <summary>
    /// Whether or not this particle can move through the given other particle.
    /// This information is cached.
    /// </summary>
    /// <param name="other">The particle to check against.</param>
    /// <returns>Whether or not this particle can move through the other.</returns>
    public MovementType CanMoveThrough(ParticleImplementation other)
    {
        return other.Weight < Weight ? MovementType.Swap : MovementType.Block;
    }
    
    public void Update(ref Particle particle, uint id, Vector2i position, Simulation sim)
    {
        // Do nothing.
    }

    public void Render(ref Particle particle, out Color color)
    {
        color = Color; // do the minimum amount of work.
    }

    public bool Spawn(ref Particle particle)
    {
        return true;
    }

    public void Delete(ref Particle particle)
    {
        
    }
}

public enum ParticleMovementProperty
{
    None = 0,
    Spread = 1,
}