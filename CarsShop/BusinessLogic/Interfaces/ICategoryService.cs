namespace CarsShop.BusinessLogic.Interfaces;
public interface ICategoryService
{
    List<CategoryDTO> GetAll();
    CategoryDTO GetById(int id);
    void Create(AddCategoryDTO categoryDto);
    void Update(CategoryDTO categoryDto);
    void Delete(int id);
}
