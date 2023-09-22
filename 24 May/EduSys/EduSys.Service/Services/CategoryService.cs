using AutoMapper;
using EduSys.Core.DTOs;
using EduSys.Core.Models;
using EduSys.Core.Repositories;
using EduSys.Core.Services;
using EduSys.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduSys.Repository.Repositories;


namespace EduSys.Service.Services;

public class CategoryService : Service<Category> , ICategoriyServices
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;


    public CategoryService(IGenericRepository<Category> repository, IUnitOfWork unitOfWork,  ICategoryRepository categoryRepository, IMapper mapper) :base(repository, unitOfWork) 
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    public async Task<CustomResponseDTO<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductAsync(int categoryId)
    {
        var category = await _categoryRepository.GetSingleCategoryByIdWithProductAsync(categoryId);
        var categoryDto = _mapper.Map<CategoryWithProductsDto>(category);
        return CustomResponseDTO<CategoryWithProductsDto>.Success(200, categoryDto); 
    }

}
