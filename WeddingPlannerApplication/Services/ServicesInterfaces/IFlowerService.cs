using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingPlannerDomain;

namespace WeddingPlannerApplication.Services.ServicesInterfaces
{
    public interface IFlowerService
    {// Interfaces-service for Flower with CRUD  methods
        Task<List<Flower>> ListAsync();
        Task<ActionResponse<Flower>> AddAsync(Flower newFlower);
        Task<ActionResponse<Flower>>UpdateAsync(int id, Flower updateFlower);
        Task<ActionResponse<Flower>> DeleteAsync(int id);
        Task<ActionResponse<Flower>> GetByIdAsync(int id);

    }
}
