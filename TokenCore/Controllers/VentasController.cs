using CharlsShoes.BLL;
using CharlsShoes.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TokenCore.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        #region Singleton
        VentaOperations ventaOperations = VentaOperations.Instance();
        #endregion
        // GET: api/<VentasController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if (ventaOperations.GetAll().Count > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Consulta exitosa",
                    productoOperations = ventaOperations.GetAll(),


                });
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Venta Erronea",
                    productoOperations = "null"


                });
            }
        }

        // GET api/<VentasController>/5
        
       

        // POST api/<VentasController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Venta newVentaOperations)
        {

            if (ventaOperations.Add(newVentaOperations) != null)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Venta creada"



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al crear el producto",



                });
            }
        }

        // PUT api/<VentasController>/5


        // DELETE api/<VentasController>/5

    }
}
