﻿using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlackSys.Models;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Net;

namespace BlackSys.Controllers
{

    public class AdminUsersController : Controller
    {
        private BlackSysEntities db = new BlackSysEntities();

        public AdminUsersController() { }

        public AdminUsersController(ApplicationUserManager userManager, ApplicationRoleManager roleManager)
        {
            UserManager = userManager;
            RoleManager = roleManager;
         
        }

        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        private ApplicationRoleManager _roleManager;
        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {

            return View(await UserManager.Users.ToListAsync());
        }

        [HttpPost]
        public ActionResult Index(string Search)
        {
            string errorMessage = "No se Encontraron Resultados"; 
            if (!String.IsNullOrEmpty(Search))
            {

                var users = (from c in UserManager.Users
                             where
                                  c.UserName.Contains(Search) || c.PhoneNumber.Contains(Search) ||
                                  c.Address.Contains(Search) || c.Email.Contains(Search)
                             select c).ToList();
                if (users.Count > 0)
                    errorMessage = "";
                return View(users);
            }
            else
            {
                var _user = UserManager.Users;
                errorMessage = "Debe escribir un valor para buscar";
                var users = _user.ToList();
                ViewBag.NotFound = errorMessage;
                return View(users);
            }

            // return View();
        }

        //
        // GET: /Users/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = await UserManager.FindByIdAsync(id);

            ViewBag.RoleNames = await UserManager.GetRolesAsync(user.Id);

            return View(user);
        }

        //
        // GET: /Users/Create
        public async Task<ActionResult> Create()
        {
            //Get the list of Roles
            ViewBag.RoleId = new SelectList(await RoleManager.Roles.ToListAsync(), "Name", "Name");           
            return View();
        }

        //
        // POST: /Users/Create
        [HttpPost]
        public async Task<ActionResult> Create(RegisterViewModel userViewModel, params string[] selectedRoles)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = userViewModel.Email,
                    Email = userViewModel.Email,
                    Address = userViewModel.Address,
                    City = userViewModel.City,
                    State = userViewModel.State,
                    PostalCode = userViewModel.PostalCode,
                    EmailConfirmed = true
                };

                // Add the Address Info:
                user.Address = userViewModel.Address;
                user.City = userViewModel.City;
                user.State = userViewModel.State;
                user.PostalCode = userViewModel.PostalCode;

                // Then create:
                var adminresult = await UserManager.CreateAsync(user, userViewModel.Password);

                //Add User to the selected Roles 
                if (adminresult.Succeeded)
                {
                    if (selectedRoles != null)
                    {
                        var result = await UserManager.AddToRolesAsync(user.Id, selectedRoles);
                        if (!result.Succeeded)
                        {
                            ModelState.AddModelError("", result.Errors.First());
                            ViewBag.RoleId = new SelectList(await RoleManager.Roles.ToListAsync(), "Name", "Name");
                            ViewBag.Result = "El Registro se guardo correctamente!";
                            return View();
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", adminresult.Errors.First());
                    ViewBag.RoleId = new SelectList(RoleManager.Roles, "Name", "Name");
                    return View();

                }
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(RoleManager.Roles, "Name", "Name");
            return View();
        }

        //
        // GET: /Users/Edit/1
        public async Task<ActionResult> Edit(string id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = await UserManager.FindByIdAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }

            var userRoles = await UserManager.GetRolesAsync(user.Id);           
            return View(new EditUserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                // Include the Addresss info:
                Address = user.Address,
                City = user.City,
                State = user.State,          
                PostalCode = user.PostalCode,
                RolesList = RoleManager.Roles.ToList().Select(x => new SelectListItem()

                {
                    Selected = userRoles.Contains(x.Name),
                    Text = x.Name,
                    Value = x.Name
                })
            });
        }

        //
        // POST: /Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Email,Id,Address,City,State,PostalCode,Password")] EditUserViewModel editUser, params string[] selectedRole)
        {
            var user = await UserManager.FindByIdAsync(editUser.Id);
            //user.PasswordHash = "Admin1.0";
            if (user == null)
            {
                // El usuario no existe, manejar según sea necesario
                return HttpNotFound();
            }
            //_userManager = userManager;

            var token = await UserManager.GeneratePasswordResetTokenAsync(user.Id);
            var result = await UserManager.ResetPasswordAsync(editUser.Id, token, editUser.Password);
           
        
            if (result.Succeeded)
            {
                // La contraseña se cambió exitosamente, puedes realizar acciones adicionales si es necesario
                return RedirectToAction("Index", "AdminUsers");
            }
            else
            {
                // Ocurrió un error al cambiar la contraseña, manejar según sea necesario
                var userRoles = await UserManager.GetRolesAsync(user.Id);  
                ModelState.AddModelError(string.Empty, "Error al cambiar la contraseña" + result.Errors.FirstOrDefault()) ;
                return View(new EditUserViewModel()
                {
                    Id = user.Id,
                    Email = user.Email,
                    Password=editUser.Password,
                    // Include the Addresss info:
                    Address = user.Address,
                    City = user.City,
                    State = user.State,
                    PostalCode = user.PostalCode,
                    RolesList = RoleManager.Roles.ToList().Select(x => new SelectListItem()

                    {
                        Selected = userRoles.Contains(x.Name),
                        Text = x.Name,
                        Value = x.Name
                    })
                });
            }
            //if (ModelState.IsValid)
            //{
            //    var user = await UserManager.FindByIdAsync(editUser.Id);
            //    if (user == null)
            //    {
            //        return HttpNotFound();
            //    }

            //    user.UserName = editUser.Email;
            //    user.Email = editUser.Email;
            //    user.Address = editUser.Address;
            //    user.City = editUser.City;
            //    user.State = editUser.State;
            //    user.PostalCode = editUser.PostalCode;
            //    //user.PasswordHash = editUser.PasswordHash;

            //    var userRoles = await UserManager.GetRolesAsync(user.Id);
            //    //IdentityResult result = await this.AppUserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword, model.NewPassword);
            //    selectedRole = selectedRole ?? new string[] { };

            //    var result = await UserManager.AddToRolesAsync(user.Id, selectedRole.Except(userRoles).ToArray<string>());

            //    if (!result.Succeeded)
            //    {
            //        ModelState.AddModelError("", result.Errors.First());
            //        return View();
            //    }
            //    result = await UserManager.RemoveFromRolesAsync(user.Id, userRoles.Except(selectedRole).ToArray<string>());

            //    if (!result.Succeeded)
            //    {
            //        ModelState.AddModelError("", result.Errors.First());
            //        return View();
            //    }
            //    return RedirectToAction("Index");
            //}
            //ModelState.AddModelError("", "Something failed.");
            //return View();
        }

        //
        // GET: /Users/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var user = await UserManager.FindByIdAsync(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        //
        // POST: /Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            if (ModelState.IsValid)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                var user = await UserManager.FindByIdAsync(id);
                if (user == null)
                {
                    return HttpNotFound();
                }
                var result = await UserManager.DeleteAsync(user);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", result.Errors.First());
                    return View();
                }
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
