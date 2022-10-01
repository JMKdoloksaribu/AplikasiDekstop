using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using AplikasiDekstop.Service.Interface.Service;
using AplikasiDekstop.Service.Service;
using AplikasiDekstop.Model.Entity;
using Microsoft.AspNetCore.Mvc;


namespace AplikasiDekstop.Controller
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProduksiController : ControllerBase
    {
        private readonly IProduksiService produksiService;

        public ProduksiController(IProduksiService produksiService)
        {
            this.produksiService = produksiService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Produksi model)
        {
            var result = await produksiService.Create(model);
            return Ok(result);
        }

        [HttpGet]
        public async Task<List<Produksi>> Get()
        {
            var result = await produksiService.Get();
            return result;
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Produksi model)
        {
            var result = await produksiService.Update(model);
            return Ok(result);
        }

        [HttpDelete("{Id:int}")]
        public async Task<IActionResult> Delete([FromBody] int id)
        {
            var result = await produksiService.Delete(id);
            return Ok(result);
        }
    }
}
