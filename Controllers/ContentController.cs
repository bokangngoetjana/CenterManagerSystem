﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CenterManagerSystem.Data;
using CenterManagerSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace CenterManagerSystem.Controllers
{
    public class ContentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContentController(ApplicationDbContext context)
        {
            _context = context;       
        }
        public async Task<IActionResult> Index(int categoryItemId)
        {
            Content content = await (from item in _context.Content
                                     where item.CategoryItem.Id == categoryItemId
                                     select new Content
                                     {
                                         Title = item.Title,
                                         VideoLink = item.VideoLink,
                                         HTMLContent = item.HTMLContent
                                     }).FirstOrDefaultAsync();


            return View(content);
        }
    }
}