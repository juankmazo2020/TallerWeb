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
        private readonly IBlobHelper _blobHelper;
        private readonly Random _random;

        public SeedDb(DataContext context, IUserHelper userHelper, IBlobHelper blobHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _blobHelper = blobHelper;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckFieldsAsync();
            await CheckProfessionsAsync();
            await CheckRolesAsync();
            await CheckUserAsync("1090305482", "Daniel", "Corzo", "tallerweb123@gmail.com", "322 3114620", "Carrera sur 5 casa No 7-6", UserType.Admin);
            await CheckUserAsync("1110975060", "Alexandra", "Duran", "alexandra@yopmail.com", "300 8574745", "Villa Del Sol Manz K Lt 27", UserType.User);
            await CheckUserAsync("657032804", "Ambrosio", "Duarte", "ambrosio@yopmail.com", "310 5723963", "Calle 10 No. 9 - 78  Centro", UserType.User);
            await CheckUserAsync("1975353454", "Andres", "Narvaez", "andres@yopmail.com", "318 1045626", "Carrera 56A No. 51 - 81", UserType.Teacher);
            await CheckUserAsync("85624651", "Bibiana", "Leal", "bibiana@yopmail.com", "300 8152019", "Carrera 22 No. 17-31", UserType.User);
            await CheckUserAsync("762032804", "Carla", "Cardenas", "Carla@yopmail.com", "310 0150711", "Carrera 54 No. 68 - 80 Barrio el Prado", UserType.User);
            await CheckUserAsync("1110975070", "Carlos", "Williams", "carlos@yopmail.com", "318 9188545", "Calle 59 No. 27 - 35 Barrio Galán", UserType.User);
            await CheckUserAsync("1887532456", "Carmen", "Cerdeño", "carmen@yopmail.com", "300 8338658", "Carrera 10A No. 20 - 40  Edificio El Clarín piso 3 Centro La Matuna", UserType.User);
            await CheckUserAsync("899032804", "Deider", "Ramos", "Deider@yopmail.com", "310 4426945", "Carrera 8  No. 20 - 59", UserType.User);
            await CheckUserAsync("32627941", "Dixon", "Gonzalez", "Dixon@yopmail.com", "350 4285939", "Calle 20 No. 22 - 27 piso 3 Edificio Cumanday", UserType.Teacher);
            await CheckUserAsync("257032804", "Edwart", "Jimenez", "Edwart@yopmail.com", "300 7502768", "Carrera 8a No. 7 - 88 /94  Barrio  La Estrella", UserType.User);
            await CheckUserAsync("1110975080", "Eliecer", "Albarraban", "Eliecer@yopmail.com", "310 6242364", "Carrera  5 No. 3 -74  centro", UserType.User);
            await CheckUserAsync("79145624", "Esmeralda", "Quintero", "Esmeralda@yopmail.com", "318 5563535", "Calle 15 No. 9 - 56 centro", UserType.User);
            await CheckUserAsync("652932804", "Ender", "Bermudez", "Ender@yopmail.com", "300 2500064", "Calle 25 No. 4 - 38 piso 2  Barrio Pandeyuca", UserType.User);
            await CheckUserAsync("98778851", "Estela", "Ortiz", "Estela@yopmail.com", "310 3623363", "Calle 28 No. 8 - 69 CENTRO", UserType.Teacher);
            await CheckUserAsync("1187784663", "Freddy", "Garzon", "Freddy@yopmail.com", "318 8048928", "Carrera 7A No. 32 - 63 piso 2", UserType.User);
            await CheckUserAsync("1110975090", "Gimena", "Kalley", "Gimena@yopmail.com", "300 8008101", "Calle 7 No. 5 - 25  Edificio Segunda", UserType.User);
            await CheckUserAsync("899032804", "Gisselle", "Silva", "Gisselle@yopmail.com", "310 7944054", "Carrera 9  No. 7 - 34", UserType.User);
            await CheckUserAsync("655486483", "Isaac", "Pertuz", "Issac@yopmail.com", "318 2369631", "Calle 20 No. 3 - 22", UserType.Teacher);
            await CheckUserAsync("89484944", "Jairo", "Martinez", "Jairo@yopmail.com", "300 4490983", "Calle 33B  No. 38 - 42  Barrio Barzal", UserType.User);
            await CheckUserAsync("789422804", "Jeison", "Borja", "Jeison@yopmail.com", "310 9619177", "Calle 16 No. 23 - 57 piso 4  Edificio Tres", UserType.User);
            await CheckUserAsync("1110975050", "Josue", "Moncada", "Josue@yopmail.com", "318 4030490", "Calle 12 No. 4 - 19  Edificio Minca", UserType.User);
            await CheckUserAsync("999448755", "Karen", "Mora", "Karen@yopmail.com", "300 3391088", "Cr 5 No. 9 - 08", UserType.User);
            await CheckUserAsync("895142804", "Kevin", "Medellin", "Kevin@yopmail.com", "310 9203842", "CALLE 23 No. 12-11", UserType.User);
            await CheckUserAsync("879867451", "Keyla", "Lopez", "Keyla@yopmail.com", "318 5730092", "Calle 19 No. 8 - 34  of. 502", UserType.User);
            await CheckUserAsync("1185248943", "Lidybeth", "Albina", "Lidybeth@yopmail.com", "300 4944582", "Avda Francisco Newball No. 4A-20 - Edif. Barte", UserType.Teacher);
            await CheckUserAsync("1110975040", "Lorena", "Montejo", "lorena@yopmail.com", "310 1555189", "Calle 31 No. 13 - 71 of. 301 Edif. Rey", UserType.User);
            await CheckUserAsync("899078924", "Luis", "Carreño", "luis@yopmail.com", "350 9496299", "Carrera 20 No. 25 - 53  Primer piso centro", UserType.User);
            await CheckUserAsync("974685165", "Maira", "Paredes", "maira@yopmail.com", "300 9321432", "Carrera 3  con Calle 28 Esquina Barrio Claret", UserType.User);
            await CheckUserAsync("1054878466", "Mario", "Paez", "mario@yopmail.com", "310 8348884", "Calle 111 No. 100 - 11  Barrio el Estadio", UserType.User);
            await CheckUserAsync("1110975020", "Marta", "Jaimes", "marta@yopmail.com", "318 0679860", "CARRERA 42 No.5C-48 Barrio Tequendama", UserType.User);
            await CheckUserAsync("875132754", "Miriam", "Garzon", "miriam@yopmail.com", "350 7006922", "Carrera 23  No. 10A - 10", UserType.Teacher);
            await CheckUserAsync("1684468465", "Pedro", "Perez", "pedro@yopmail.com", "318 0706022", "Villa De la luna Manz K Lt 27", UserType.User);
            await CheckUserAsync("789465123", "Priscila", "Duarte", "priscila@yopmail.com", "350 3610513", "Calle 15 No. 15 - 10  Centro", UserType.User);
            await CheckUserAsync("1110975030", "Ramon ", "Sandoval", "ramon@yopmail.com", "318 2667568", "Carrera 76A No. 71 - 11", UserType.User);
            await CheckUserAsync("587485415", "Robert", "Hernandez", "Robert@yopmail.com", "312 1273982", "Carrera 12 No. 18-25", UserType.Teacher);
            await CheckUserAsync("687684561", "Edwart", "Trompiz", "Edwart@yopmail.com", "350 5098772", "Carrera 52 No. 78 - 20 Barrio el Reino", UserType.User);
            await CheckUserAsync("156468484", "Rebeca", "Colmenares", "Rebeca@yopmail.com", "315 0456705", "Calle 59 No. 27 - 35 Barrio Galán", UserType.User);
            await CheckUserAsync("1110975010", "Rut", "Maldonado", "Rut@yopmail.com", "350 5725958", "Carrera 10B No. 30 - 20  Edificio La Rana", UserType.User);
            await CheckUserAsync("654484562", "Sansa", "Stark", "Sansa@yopmail.com", "312 0149966", "Carrera 81  No. 40 - 59", UserType.User);
            await CheckUserAsync("757139713", "Sara", "Montealegre", "Sara@yopmail.com", "315 5000434", "Calle 19 No. 20 - 27 piso 8 Edificio Simba", UserType.User);
            await CheckUserAsync("54748465", "Selena", "Gomez", "Selena@yopmail.com", "350 6836064", "Carrera 7a No. 8 - 50  Barrio Himena", UserType.Teacher);
            await CheckUserAsync("1110975000", "Steve", "Jobs", "Steve@yopmail.com", "312 5952404", "Carrera  7 No. 4 -52  centro", UserType.User);
            await CheckUserAsync("1005472344", "Sugey", "Niño", "Sugey@yopmail.com", "350 2547780", "Calle 20 No. 4 - 86 centro", UserType.User);
            await CheckUserAsync("678674864", "Viviana", "Delgado", "viviana@yopmail.com", "312 7110873", "Calle 10 No. 14 - 48 piso 1  Barrio Dionisio", UserType.User);
            await CheckUserAsync("849846465", "Wilmer", "Roa", "Wilmer@yopmail.com", "315 6307146", "Calle 25 No. 7 - 49 CENTRO", UserType.User);
            await CheckUserAsync("1110975580", "William ", "Candelo", "william@yopmail.com", "350 9916648", "Carrera 8C No. 15 - 61 piso 4", UserType.User);
            await CheckUserAsync("975343654", "Ximena", "Vargas", "ximena@yopmail.com", "312 7993222", "Calle 17 No. 51 - 20  Edificio Primera", UserType.User);
            await CheckUserAsync("545864651", "Yurley ", "Garcia", "Yurley@yopmail.com", "350 2171658", "Carrera 8  No. 71 - 20", UserType.User);
        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Admin.ToString());
            await _userHelper.CheckRoleAsync(UserType.Teacher.ToString());
            await _userHelper.CheckRoleAsync(UserType.User.ToString());
        }
        Random rnd = new Random();
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

