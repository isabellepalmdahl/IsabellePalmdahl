using IsabellePalmdahl.Data;
using IsabellePalmdahl.Models.POCOs;
//using MySqlX.XDevAPI;

namespace IsabellePalmdahl.Repositories
{
	public class DbRepository : IDbRepository
	{
  //      private List<Client> _clients = new List<Client>
  //      {
  //          new Client { Id = 0, Name = "IPTest", Email = "ip@hotmail.com", Message="Test", Phone = 555},
		//	new Client { Id = 1, Name = "IPTest2", Email = "ip2@hotmail.com", Message="Test2", Phone = 2555}
		//};

        private readonly AppDbContext _context;
        public DbRepository(AppDbContext context)
        {
            this._context = context;
            //SeedClients();
        }

        //public Client GetClientById(int id)
        //{
        //    var client = _context.Clients.Find(id);
        //    return client;
        //}

        //public async Task<Client> GetClientAsync(string name)
        //{
        //    var client = new Client()
        //    {
        //        Name = name,
        //    };
        //   await _context.AddAsync(client);
        //    _context.SaveChanges();
        //    return client;
        //}

        //private void SeedClients()
        //{
        //    if (_context.Clients.Count() == 0)
        //    {
        //        _context.AddRange(_clients);
        //        _context.SaveChanges();
        //    }
        //}
    }
}
