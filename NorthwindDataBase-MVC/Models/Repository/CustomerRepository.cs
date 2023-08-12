using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NorthwindDataBase_MVC.Data;
using NorthwindDataBase_MVC.Models.DTOS;
using NorthwindDataBase_MVC.Models.Entity;

namespace NorthwindDataBase_MVC.Models.Repository
{
    public class CustomerRepository
    {
        private FileContext _context;
        private IMapper _mapper;
        public CustomerRepository(FileContext fileContext,IMapper mapper)
        {
            _context = fileContext;
            _mapper = mapper;
        }
        public async Task<bool> EmailExist(string email)
        {
            return await _context.Customers.AnyAsync(x => x.Email == email);
        }
        public async Task<ReturnCustomerDTO> FindCustomerByEmail(string email)
        {
            Customer customer =  await _context.Customers.FirstOrDefaultAsync(x => x.Email == email);
            ReturnCustomerDTO returnCustomerDTO = _mapper.Map<ReturnCustomerDTO>(customer);
            return returnCustomerDTO;
        }
        public async Task<ReturnCustomerDTO> CreateNewCustomer(NewCustomerDTO newCustomerDTO)
        {
            Customer customerEntity = _mapper.Map<NewCustomerDTO, Customer>(newCustomerDTO);
            await _context.AddAsync(customerEntity);
            var returnCustomerDTO = await FindCustomerByEmail(newCustomerDTO.Email);
            return returnCustomerDTO;
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
