﻿using Core_Project_Api.DAL.ApiContext;
using Core_Project_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Project_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var c = new Context();
            return Ok(c.Categories.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);

            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            using var c = new Context();
            c.Add(category);
            c.SaveChanges();
            return Created("",category);
        }


        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if(value==null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }

        [HttpPut]
        public IActionResult CategoryUpdate(Category category)
        {
            using var c = new Context();
            var value = c.Find<Category>(category.CategoryID);
            if(value==null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = category.CategoryName;
                c.Update(value);
                c.SaveChanges();
                return NoContent(); 
            }
        }
    }
}
