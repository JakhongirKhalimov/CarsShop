namespace CarsShop.BusinessLogic.Services
{
    public class CategoryService(IUnitOfWork unitOfWork)
        : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork = unitOfWork;
        public void Create(AddCategoryDTO categoryDto)
        {
            if (categoryDto == null)
            {
                throw new ArgumentNullException("Category was null");
            }
            if (string.IsNullOrEmpty(categoryDto.Name))
            {
                throw new Errors("Category name is required");
            }
            if (categoryDto.Name.Length < 3 || categoryDto.Name.Length > 50)
            {
                throw new Errors("Category name should include between 3 and 50 letters");
            }
            Category category = new Category()
            {
                Name = categoryDto.Name
            };
            _unitOfWork.Categories.Add(category);
            
        }

        public void Delete(int id)
        {
            var categories = _unitOfWork.Categories.GetById(id);
            if(categories == null)
            {
                throw new Errors("Category was not found"); 
            }
            _unitOfWork.Categories.Delete(categories.Id);
        }

        public List<CategoryDTO> GetAll()
        {
            var category = _unitOfWork.Categories.GetAll();
            var list = category.Select(c => new CategoryDTO()
            {
                Id = c.Id, Name = c.Name
            }).ToList();
            return list;
        }

        public CategoryDTO GetById(int id)
        {
            var categories = _unitOfWork.Categories.GetById(id);
            if (categories == null)
            {
                throw new Errors("Category was not found");
            }
            var dto = new CategoryDTO()
            {
                Id = categories.Id,
                Name = categories.Name
            };
            return dto;
        }

        public void Update(CategoryDTO categoryDto)
        {
            var categories = _unitOfWork.Categories.GetById(categoryDto.Id);
            if (categories == null)
            {
                throw new Errors("Category was not found");
            }
            if (string.IsNullOrEmpty(categoryDto.Name))
            {
                throw new Errors("Category name is required");
            }
            if (categoryDto.Name.Length < 3 || categoryDto.Name.Length > 50)
            {
                throw new Errors("Category name should include between 3 and 50 letters");
            }

            var dto = new Category()
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
            };

            _unitOfWork.Categories.Update(dto);

        }
    }
}
