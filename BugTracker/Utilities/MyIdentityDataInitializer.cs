using BugTracker.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Utilities
{
    public static class MyIdentityDataInitializer
    {
        public static void SeedData(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager,
            IOrganizationRepo organizationManager)
        {
            SeedRoles(roleManager);
            SeedOrganizations(organizationManager);
            SeedUsers(userManager);
        }

        public static void SeedOrganizations(IOrganizationRepo organizationRepo)
        {
            if(organizationRepo.GetOrganization(1) == null)
            {
                Organization organization = new Organization
                {
                    Name = "TestName",
                    Created = DateTime.Now
                };

                organizationRepo.Add(organization);
            }
        }

        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByNameAsync("firstuser").Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.UserName = "firstuser@test.com";
                user.Email = "firstuser@test.com";
                user.FirstName = "John";
                user.LastName = "Almazan";
                user.Organization = "Face";
                user.TeamOwner = "firstuser@test.com";
                user.OrganizationId = 1;

                IdentityResult result = userManager.CreateAsync
                (user, "1234_Test").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user,
                                        "Admin").Wait();
                }
            }
        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Operations").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Operations";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }


            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.
                CreateAsync(role).Result;
            }
        }
    }
}
