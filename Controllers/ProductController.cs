using Microsoft.AspNetCore.Mvc;

namespace MyFastApi.Controllers;

[Route("api/[controller]")] // Tương đương: api/product
[ApiController]
public class ProductController : ControllerBase
{
    // GET: api/product
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new string[] { "Product 1", "Product 2" });
    }

    // GET: api/product/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok($"Value {id}");
    }

    // POST: api/product
    [HttpPost]
    public IActionResult Post([FromBody] object value)
    {
        // Xử lý tạo mới...
        return Ok(new { message = "Created", data = value });
    }

    // PUT: api/product/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] object value)
    {
        // Xử lý update...
        return Ok(new { message = "Updated", id = id });
    }

    // DELETE: api/product/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Xử lý xóa...
        return Ok(new { message = "Deleted", id = id });
    }
}