using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class DiamondRepository : IDiamondRepository
    {
        private List<Diamond> diamonds = new List<Diamond>();

        public Diamond GetDiamondById(int diamondId)
        {
            return diamonds.FirstOrDefault(d => d.DiamondId == diamondId);
        }

        public IEnumerable<Diamond> GetAllDiamonds()
        {
            return diamonds;
        }

        public void AddDiamond(Diamond diamond)
        {
            diamonds.Add(diamond);
        }

        public void UpdateDiamond(Diamond diamond)
        {
            var existingDiamond = GetDiamondById(diamond.DiamondId);
            if (existingDiamond != null)
            {
                existingDiamond.Name = diamond.Name;
                existingDiamond.Size = diamond.Size;
                existingDiamond.Weight = diamond.Weight;
                existingDiamond.Color = diamond.Color;
                existingDiamond.Price = diamond.Price;
               
            }
        }

        public void DeleteDiamond(int diamondId)
        {
            var diamond = GetDiamondById(diamondId);
            if (diamond != null)
            {
                diamonds.Remove(diamond);
            }
        }
    }
}
