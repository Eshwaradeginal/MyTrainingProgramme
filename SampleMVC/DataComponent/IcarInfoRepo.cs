using System.Collections.Generic;

namespace SampleMVC.DataComponent
{
    public interface IcarInfoRepo
    {
        void AddNewCar(CarInfo info);
        void DeleteCar(int entryId);
        CarInfo FindCar(int id);
        List<CarInfo> GetAllCars();
        void UpdateCar(CarInfo carInfo);
    }
}