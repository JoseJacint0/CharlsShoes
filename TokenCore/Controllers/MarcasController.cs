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
    public class MarcasController : ControllerBase
    {
        #region Singleton
        MarcaOperations marcaOperations = MarcaOperations.Instance();
        #endregion
        // GET: api/<MarcasController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if (marcaOperations.GetAll().Count > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Consulta exitosa",
                    marcaOperations = marcaOperations.GetAll(),


                });
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Marca Erronea",
                    marcaOperations = "null"


                });
            }
        }

        // GET api/<MarcasController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (marcaOperations.GetById(id) != null)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Consulta exitosa",
                    marcaOperations = marcaOperations.GetById(id),


                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al consultar la marca",
                    marcaOperations = "null"


                });
            }
        }

        // POST api/<MarcasController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Marca newMarcaOperations)
        {

            if (marcaOperations.Add(newMarcaOperations) > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Marca creada"



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al crear la marca",



                });
            }
        }

        // PUT api/<MarcasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Marca newMarcaOperations)
        {


            var item = marcaOperations.GetById(id);

            if (item != null)
            {


                item.descripcion = newMarcaOperations.descripcion;





                if (marcaOperations.Update(item) > 0)
                {
                    return StatusCode(StatusCodes.Status201Created, new
                    {
                        status = true,
                        message = "Marca modificada"



                    });

                }
                else
                {
                    return StatusCode(StatusCodes.Status401Unauthorized, new
                    {
                        status = false,
                        message = "Error al modificar la marca",



                    });
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al modificar la marca",



                });
            }
        }

        // DELETE api/<MarcasController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (marcaOperations.Delete(id) > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Marca eliminada",



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al eliminar la marca",



                });
            }
        }
    }
}
