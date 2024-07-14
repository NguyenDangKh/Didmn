
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    internal interface IDiamondRepository
    {
        Diamond GetDiamondById(int diamondId);
        IEnumerable<Diamond> GetAllDiamonds();
        void AddDiamond(Diamond diamond);
        void UpdateDiamond(Diamond diamond);
        void DeleteDiamond(int diamondId);
    }
}
