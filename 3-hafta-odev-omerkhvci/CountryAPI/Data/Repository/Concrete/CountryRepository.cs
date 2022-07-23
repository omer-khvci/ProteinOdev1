using Data.Context;
using Data.Model;
using Data.Repository;
using Data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Concrete
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DapperDbContext dapperDbContext;

        public CountryRepository(DapperDbContext dapperDbContext) : base()
        {
            this.dapperDbContext = dapperDbContext;
        }

        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            var sql = $"SELECT \"Id\",\"Name\",\"DepartmentId\",\"Continent\",\"Currency\",\"CreatedAt\" FROM \"Countries\" WHERE \"IsDeleted\"=false";
            using (var connection = dapperDbContext.CreateConnection())
            {

                var result = await connection.QueryAsync<Country>(sql);
                return result;
            }
        }

        public Task<Country> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveAsync(Country entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Country entity)
        {
            throw new NotImplementedException();
        }
    }
}
