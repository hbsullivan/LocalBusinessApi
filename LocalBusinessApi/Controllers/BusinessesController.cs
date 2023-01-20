using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;

namespace LocalBusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly LocalBusinessApiContext _db;

    public BusinessesController(LocalBusinessApiContext db)
    {
      _db = db;
    }

    //GET api/businesses
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Business>>> Get(string category)
    {
      IQueryable<Business> query = _db.Businesses.AsQueryable();

    //GET api/businesses?category=restaurant
      if (category != null)
      {
        query = query.Where(entry => entry.Category == category);
      }

      return await query.ToListAsync();
    }

    //GET api/businesses/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
      Business business = await _db.Businesses.FindAsync(id);

      if(business == null)
      {
        return NotFound();
      }

      return business;
    }

    //POST api/businesses
    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }

    //PUT: api/businesses/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Business business)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }

      _db.Businesses.Update(business);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool BusinessExists(int id)
    {
      return _db.Businesses.Any(e => e.BusinessId == id);
    }

    //Delete: api/businesses/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      Business business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}