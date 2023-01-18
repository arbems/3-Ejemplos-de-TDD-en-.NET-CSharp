using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project;

public class DataSearcher
{
    private readonly SampleDbContext _context;

    public DataSearcher(SampleDbContext context)
    {
        _context = context;
    }

    public List<Customer> Search(string term)
    {
        return _context.Customers.Where(x => x.Name.Contains(term)).ToList();
    }
}
