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
    public class ColoresController : ControllerBase
    {
        #region Singleton
        ColorOperations colorOperations = ColorOperations.Instance();
        #endregion
        // GET: api/<ColoresController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            if (colorOperations.GetAll().Count > 0) {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Consulta exitosa", 
                    colorOperations = colorOperations.GetAll(),


                });
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Color Erroneo",
                    colorOperations = "null"


                });
            }
        }



        // GET api/<ColoresController>/5
        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            if (colorOperations.GetById(id) != null)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Consulta exitosa",
                    colorOperations = colorOperations.GetById(id),


                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al consultar color",
                    colorOperations = "null"


                });
            }
        }
    

        // POST api/<ColoresController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Color newColorOperations)
        {

            if (colorOperations.Add(newColorOperations) > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Color creado"



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al crear color",



                });
            }
        }

        // PUT api/<ColoresController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Color newColorOperations)
        {


            var item = colorOperations.GetById(id);

            if (item != null)
            {


                item.descripcion = newColorOperations.descripcion;





                if (colorOperations.Update(item) > 0)
                {
                    return StatusCode(StatusCodes.Status201Created, new
                    {
                        status = true,
                        message = "Color modificado"



                    });

                }
                else
                {
                    return StatusCode(StatusCodes.Status401Unauthorized, new
                    {
                        status = false,
                        message = "Error al modificar color",



                    });
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al modificar color",



                });
            }
        }

        // DELETE api/<ColoresController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (colorOperations.Delete(id) > 0)
            {
                return StatusCode(StatusCodes.Status201Created, new
                {
                    status = true,
                    message = "Color eliminado",



                });

            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new
                {
                    status = false,
                    message = "Error al eliminar Color",



                });
            }
        }
    }
}
