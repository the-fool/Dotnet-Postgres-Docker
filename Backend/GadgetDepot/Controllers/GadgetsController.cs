using System;
using System.Collections.Generic;
using System.Linq;
using GadgetDepot.Models;
using Microsoft.AspNetCore.Mvc;

namespace GadgetDepot.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class GadgetsController : ControllerBase {
        ApiDbContext ctx;

        public GadgetsController(ApiDbContext _ctx) {
            ctx = _ctx;
        }

        [HttpGet]
        public ActionResult<List<Gadget>> Get() {
            return ctx.Gadgets.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Gadget> Get(int id) {
            var gadget = ctx.Gadgets
                .FirstOrDefault(g => g.Id == id);
            if (gadget == null) {
                return NotFound();
            }
            return gadget;
        }
    }
}