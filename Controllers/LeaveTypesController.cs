using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Data;
using AutoMapper;
using LeaveManagement.Common.Models;
using System.Drawing;
using System.Reflection.Metadata;
using LeaveManagement.Application.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Common.Constants;


/* The IActionResult interface in ASP.NET Core represents the result of an
 action method and provides a way to return various types of responses,
 such as a view, a file, or JSON data, from an action method to the client. */

/* The IMapper interface provides methods for mapping objects of one type to objects of 
 * another type. It defines methods such as Map, Map<TDestination>, and Map<TSource, 
 * TDestination>, which can be used to map objects of different types. */

namespace LeaveManagement.Web.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
       
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        public LeaveTypesController(ILeaveTypeRepository leaveTypeRepository, 
            IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
 
             var leaveTypes = mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync()); 
            //This code is using the AutoMapper library to map a list of LeaveType entities retrieved from the database context "_context" to a list of LeaveTypeVM (view model) objects, and then returning a view with that list of view model objects.
            return View(leaveTypes);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id) 
        {
			

			var leaveType = await leaveTypeRepository.GetAsync(id);
			if (leaveType == null)
			{
				return NotFound();
			}

			var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
			return View(leaveTypeVM);
            /*This code defines an action method called "Details" that takes an integer "id"
            parameter, retrieves a LeaveType entity with the specified "id" from the database context
            "_context" using the FindAsync method, maps that entity to a LeaveTypeVM (view model)
           object using AutoMapper, and then returns a view with that view model object.
           It also includes null and not-found checks to handle
           scenarios where the "id" parameter is null or the specified LeaveType
            entity cannot be found in the database.*/

        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                await leaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
            /*This code defines an action method called "Create" that accepts a POST request 
            and a LeaveTypeVM (view model) object as its parameter.
            It first checks if the model state is valid and if so, maps the LeaveTypeVM
            object to a LeaveType entity using AutoMapper, adds the entity to 
            the database context "_context", saves the changes to the 
            database using SaveChangesAsync method, and then redirects the user 
            to the "Index" action method. If the model state is not valid, the method 
            returns the same view with the LeaveTypeVM object 
            to display validation errors to the user. */
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            
            var leaveType = await leaveTypeRepository.GetAsync(id);
                mapper.Map<LeaveTypeVM>(leaveType);
            if (leaveType == null)
            {
                return NotFound();
            }
                
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
            /* This code defines an action method called "Edit" that takes an integer 
             "id" parameter, retrieves a LeaveType entity with the specified "id" from the 
            database context "_context" using the FindAsync method, maps that entity to 
            a LeaveTypeVM (view model) object using AutoMapper, and then returns a view 
            with that view model object. It also includes null and not-found checks to 
            handle scenarios where the "id" parameter is null or the specified LeaveType 
            entity cannot be found in the database.*/

        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  LeaveTypeVM leaveTypeVM) //This code filters out everything that doesnt match whats inside
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            var leaveType = await leaveTypeRepository.GetAsync(id);
            if(leaveType == null) { 
            return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
					mapper.Map<LeaveType>(leaveTypeVM);
					await leaveTypeRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        
       

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leaveTypeRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(int id)
        {
            await leaveAllocationRepository.LeaveAllocation(id);
            return RedirectToAction(nameof(Index));
        }
      
    }
}
