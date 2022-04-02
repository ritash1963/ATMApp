using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.DTOs;
using AutoMapper;
using API.Helpers;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _repo;
        private readonly IMapper _mapper;

        public AccountController(IAccountRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;

        }
   
       [HttpPost("login")]
       public async Task<ActionResult<AccountDto>> Login(LoginDto loginDto)
       {
          var account = await _repo.GetAccount(loginDto.PIN);
          if (account == null) return Unauthorized("Account is not exists");
          var accountDto = _mapper.Map<AccountDto>(account);
          return accountDto;
       }
    
       [HttpPost("operations")]
       public async Task<ActionResult<List<Operation>>> GetOperations(AccountDto accountDto)
       {
          var operations  = await _repo.GetOperations(accountDto.Id);
          return operations;
       }

       [HttpPost("add")]
        public async Task<IActionResult> AddOperation(OperationDto operationDto)
        {
             operationDto.CreDate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
             var operation = _mapper.Map<Operation>(operationDto); 
              _repo.Add(operation);

             if (await _repo.SaveAll())
                return StatusCode(201);
         
             return BadRequest("Could not add operation");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBalance(int id, AccountDto accountDto)
        {
         
            var accountFromRepo = await _repo.GetClientAccount(id);

            _mapper.Map(accountDto, accountFromRepo);

            if (await _repo.SaveAll())
                return NoContent();
            
            return BadRequest("Updating balance failed on save");
        }

    }
}