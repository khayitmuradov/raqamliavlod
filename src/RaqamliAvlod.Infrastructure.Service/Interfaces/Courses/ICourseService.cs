﻿using RaqamliAvlod.Application.Utils;
using RaqamliAvlod.Application.ViewModels.Courses;
using RaqamliAvlod.Infrastructure.Service.Dtos;

namespace RaqamliAvlod.Infrastructure.Service.Interfaces.Courses;

public interface ICourseService
{
    Task<bool> CreateAsync(long ownerId, CourseCreateDto dto);
    Task<bool> UpdatePutAsync(long ownerId, CourseUpdateDto dto);
    Task<bool> UpdatePatchAsync(long ownerId, CourseUpdateDto dto);
    Task<bool> DeleteAsync(long id);
    Task<CourseViewModel> GetAsync(long id);
    Task<IEnumerable<CourseViewModel>> GetAllAsync(PaginationParams @params);
    Task<IEnumerable<CourseViewModel>> SearchByTitleAsync(string text, PaginationParams @params);
}
