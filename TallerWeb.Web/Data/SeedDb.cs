using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TallerWeb.Common.Entities;
using TallerWeb.Common.Enums;
using TallerWeb.Web.Data.Entities;
using TallerWeb.Web.Helpers;

namespace TallerWeb.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckFieldsAsync();
            await CheckProfessionsAsync();
            await CheckRolesAsync();
            await CheckUserAsync("1010", "Juan", "Zuluaga", "jzuluaga55@hotmail.com", "322 311 4620", "Calle Luna Calle Sol", UserType.Admin);

        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }

        private async Task<User> CheckUserAsync(
            string document,
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            UserType userType)
        {
            User user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document,
                    Church = _context.Churches.FirstOrDefault(),
                    Profession = _context.Professions.FirstOrDefault(),
                    UserType = userType
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());

                string token = await _userHelper.GenerateEmailConfirmationTokenAsync(user);
                await _userHelper.ConfirmEmailAsync(user, token);

            }

            return user;
        }


        private async Task CheckProfessionsAsync()
        {
            if (!_context.Professions.Any())
            {
                _context.Professions.Add(new Profession
                {
                    Name = "Ingeniero"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Misionero"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Contador"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Administrador"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Economista"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Educador"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Chef"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Musica"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Medicina"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Enfermeria"
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckFieldsAsync()
        {
            if (!_context.Fields.Any())
            {

                _context.Fields.Add(new Field
                {
                    Name = "Colombia",
                    Districts = new List<District>
                    {
                        new District
                        {
                            Name = "Capital",
                            Churches = new List<Church>
                            {
                                new Church { Name = "Templo San Agustin" },
                                new Church { Name = "Parroquia Santa Monica" },
                                new Church { Name = "Basilica Menor Nuestra señora de Lourdes" }
                            }
                        },
                        new District
                        {
                            Name = "Cartagena",
                            Churches = new List<Church>
                            {
                                new Church { Name = "Iglesia de la Santisima Trinidad" }
                            }
                        },
                        new District
                        {
                            Name = "Santa Marta",
                            Churches = new List<Church>
                            {
                                new Church { Name = "Parroquia San Jose" },
                                new Church { Name = "Iglesia los Almendros" },
                                new Church { Name = "Iglesia Nuestra Señora del Carmen" }
                            }
                        }
                    }
                });
                _context.Fields.Add(new Field
                {
                    Name = "Panama",
                    Districts = new List<District>
                    {
                        new District
                        {
                            Name = "Bocas del Toro",
                            Churches = new List<Church>
                            {
                                new Church { Name = "Iglesia de Cristo" },
                                new Church { Name = "Iglesia Adventista del Septimo Dia" },
                                new Church { Name = "Iglesia la Luz del Mundo" }
                            }
                        },
                        new District
                        {
                            Name = "Changuinola",
                            Churches = new List<Church>
                            {
                            new Church { Name = "Iglesia Cristiana Evangelista" },
                            new Church { Name = "Templo Siloe" }
                            }
                        }
                    }
                });

                await _context.SaveChangesAsync();
            }


        }
    }
}

