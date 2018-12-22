using GadgetDepot.Models;
using System.Linq;

namespace GadgetDepot {
    public class DbInitializer {
        public static void Initialize(ApiDbContext ctx) {
            ctx.Database.EnsureCreated();
            var test = ctx.Gadgets.FirstOrDefault();
            if (test == null) {
                ctx.Gadgets.Add(new Gadget { Name = "plumbus" });
                ctx.Gadgets.Add(new Gadget { Name = "flux capacitor" });
                ctx.Gadgets.Add(new Gadget { Name = "spline reticulator" });
            }
            ctx.SaveChanges();
        }
    }
}