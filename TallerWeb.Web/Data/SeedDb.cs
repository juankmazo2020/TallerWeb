using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TallerWeb.Common.Entities;
using TallerWeb.Common.Enums;
using TallerWeb.Common.Models;
using TallerWeb.Common.Services;
using TallerWeb.Web.Data.Entities;
using TallerWeb.Web.Helpers;

namespace TallerWeb.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private readonly IBlobHelper _blobHelper;
        private readonly IApiService _apiService;
        private readonly Random _random;

        public SeedDb(DataContext context, IUserHelper userHelper, IBlobHelper blobHelper, IApiService apiService)
        {
            _context = context;
            _userHelper = userHelper;
            _blobHelper = blobHelper;
            _apiService = apiService;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckFieldsAsync();
            await CheckProfessionsAsync();
            await CheckRolesAsync();
            await CheckUsersAsync();

        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.Teacher.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }

        private async Task CheckUsersAsync()
        {
            if (!_context.Users.Any())
            {
                await CheckAdminsAsync();
                await CheckBuyersAsync();
                await CheckTeachersAsync();
            }
        }

        private async Task CheckBuyersAsync()
        {
            for (int i = 1; i <= 150; i++)
            {
                await CheckUserAsync($"300{i}", $"buyer{i}@yopmail.com", UserType.User);
            }
        }

        private async Task CheckTeachersAsync()
        {
            for (int i = 1; i <= 20; i++)
            {
                await CheckUserAsync($"200{i}", $"Teacher{i}@yopmail.com", UserType.Teacher);
            }
        }

        private async Task CheckAdminsAsync()
        {
            await CheckUserAsync("1001", "admin1@yopmail.com", UserType.Admin);
        }

        private async Task<User> CheckUserAsync(
            string document,
            string email,
            UserType userType)
        {
            RandomUsers randomUsers;

            do
            {
                randomUsers = await _apiService.GetRandomUser("https://randomuser.me", "api");
            } while (randomUsers == null);

            Guid imageId = Guid.Empty;
            RandomUser randomUser = randomUsers.Results.FirstOrDefault();
            string imageUrl = randomUser.Picture.Large.ToString().Substring(22);
            Stream stream = await _apiService.GetPictureAsync("https://randomuser.me", imageUrl);
            if (stream != null)
            {
                imageId = await _blobHelper.UploadBlobAsync(stream, "users");
            }

            int churchId = _random.Next(1, _context.Churches.Count());
            int professionId = _random.Next(1, _context.Professions.Count());
            User user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = randomUser.Name.First,
                    LastName = randomUser.Name.Last,
                    Email = email,
                    UserName = email,
                    PhoneNumber = randomUser.Cell,
                    Address = $"{randomUser.Location.Street.Number}, {randomUser.Location.Street.Name}",
                    Document = document,
                    UserType = userType,
                    Church = await _context.Churches.FindAsync(churchId),
                    Profession = await _context.Professions.FindAsync(professionId),
                    ImageId = imageId
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
                    Name = "Ingeniero(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Misionero"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Contador(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Administrador(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Economista"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Educador(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Chef"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Músico(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Doctor(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Enfermería"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Programador(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Barbero(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Profesor(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Policia"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Abogado(a)"
                });
                _context.Professions.Add(new Profession
                {
                    Name = "Publicista"
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
                                new Church { Name = "Basilica Menor Nuestra señora de Lourdes" }
                            }
                        },
                        new District
                        {
                            Name = "Santa Marta",
                            Churches = new List<Church>
                            {
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

