﻿using CMS.Service.DTOs.DesignCategories;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface IDesignCategoryService
{
    Task<Response<DesignCategoryResultDto>> CreateAsync(DesignCategoryCreationDto dto);
    Task<Response<DesignCategoryResultDto>> UpdateAsync(DesignCategoryUpdateDto dto);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<DesignCategoryResultDto>>> GetAllAsync();
}