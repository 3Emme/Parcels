using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class ParcelsController : Controller
    {
        [HttpGet ("/parcels")]
        public ActionResult Index () {
            List<Parcel> myParcel = Parcel.GetAll ();
            return View (myParcel);
        }
        [HttpGet("/parcels/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        
        [HttpPost ("/parcels")]
        public ActionResult Create (int weight, int height, int length, int width) {
            Parcel myParcel = new Parcel (weight,height,length,width);
            return RedirectToAction ("Index");
        }
    }
}