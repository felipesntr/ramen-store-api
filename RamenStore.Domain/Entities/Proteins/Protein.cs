﻿using RamenStore.Domain.Abstractions;

namespace RamenStore.Domain.Entities.Proteins;

public sealed class Protein : Entity<string>
{
    public Protein(string id, string imageInactive, string imageActive, string name, string description, decimal price) : base(id)
    {
        ImageInactive = imageInactive;
        ImageActive = imageActive;
        Name = name;
        Description = description;
        Price = price;
    }

    public string ImageInactive { get; private set; }
    public string ImageActive { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
}
