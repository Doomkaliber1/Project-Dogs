using DogApp.Abstraction;
using DogApp.Data;
using DogApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApp.Services
{
    public class DogService : IDogService
    {
        private readonly ApplicationDbContext _context;

        public DogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Create(string name, int age, string breed, string picture)
        {
            Dog item = new Dog
            {
                Name = name,
                Age = age,
                Breed = breed,
                Picture = picture,
            };

            _context.Dogs.Add(item);
            return _context.SaveChanges() != 0;
        }

        public Dog GetDogById(int dogId)
        {
            throw new NotImplementedException();
        }

        public List<Dog> GetDogs()
        {
            throw new NotImplementedException();
        }

        public bool RemoveById(int dogId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDog(int dogId, string name, int age, string breed, string picture)
        {
            throw new NotImplementedException();
        }
    }
}
    

