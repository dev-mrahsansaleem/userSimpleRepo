using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using userAuth.Data;
using userAuth.DTOs;
using userAuth.Models;

namespace userAuth.Controllers
{
    // api/users
    [Route("api/[Controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepo _repo;
        private readonly IMapper _mapper;

        public UsersController(IUserRepo userRepo, IMapper mapper)
        {
            _repo = userRepo;
            _mapper = mapper;
        }
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<UserReadDTO>> getAllUsers()
        {
            return Ok(_mapper.Map<IEnumerable<UserReadDTO>>(_repo.GetAllUsers()));
        }

        // GET api/users/{id}
        // GET api/users/5
        [HttpGet("{id}", Name = "getUserById")]
        public ActionResult<UserReadDTO> getUserById(int id)
        {
            var User = _repo.getUserById(id);
            if (User != null)
            {
                return Ok(_mapper.Map<UserReadDTO>(User));
            }
            return NotFound();
        }
        // POST api/users
        [HttpPost]
        public ActionResult<UserReadDTO> CreateUser(UserCreateDTO userCreateDTO)
        {
            if (userCreateDTO != null)
            {
                var UserModal = _mapper.Map<User>(userCreateDTO);
                _repo.CreateUser(UserModal);
                _repo.SaveChanges();
                var userReadDto = _mapper.Map<UserReadDTO>(UserModal);
                return CreatedAtRoute(nameof(getUserById), new { Id = userReadDto.id }, userReadDto);

                // return Ok(_mapper.Map<UserReadDTO>(UserModal));

            }
            return NotFound();
        }
    }
}