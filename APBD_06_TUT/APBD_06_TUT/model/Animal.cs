﻿namespace APBD_06.model;

public class Animal(int id, string name, string category, double weight, string furColor)
{
    public int Id { get; } = id;
    public string Name { get; set; } = name;
    public string Category { get; set; } = category;
    public double Weight { get; set; } = weight;
    public string FurColor { get; set; } = furColor;
}