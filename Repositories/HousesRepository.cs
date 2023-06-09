using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharpList.Repositories
{
  public class HousesRepository
  {
    private readonly IDbConnection _db;

    public HousesRepository(IDbConnection db)
    {
      _db = db;
    }

    internal List<House> GetAllHouses()
    {
      string sql = @"
      SELECT
      *
      FROM houses;
      ";
      List<House> houses = _db.Query<House>(sql).ToList();
      return houses;
    }
  }
}