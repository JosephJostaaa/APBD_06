using APBD_06.model;

namespace APBD_06.service;

public class AnimalsService
{
    public void AddAnimal(Animal animal)
    {
        Database.Animals.Add(animal);        
    }

    public List<Animal> GetAllAnimals()
    {
        return Database.Animals;
    }

    public Animal GetAnimalById(int id)
    {
        var result = Database.Animals.Find(x => x.Id == id);
        result = result ?? throw new KeyNotFoundException("Animal not found");
        return result;
    }

    public void DeleteAnimalById(int id)
    {
        var result = Database.Animals.Find(x => x.Id == id);
        result = result ?? throw new KeyNotFoundException("Animal not found");
        Database.Animals.Remove(result);
    }

    public void UpdateAnimal(Animal animal)
    {
        var result = Database.Animals.Find(x => x.Id == animal.Id);
        result = result ?? throw new KeyNotFoundException("Animal not found");
        
        result.Name = animal.Name;
        result.Category = animal.Category;
        result.FurColor = animal.FurColor;
        result.Weight = animal.Weight;
    }
    
    
    
    
}