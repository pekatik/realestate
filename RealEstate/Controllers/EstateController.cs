using AutoMapper;
using RealEstate.Models;
using RealEstateApplication.Dtos;
using RealEstateApplication.Services;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class EstateController : Controller
    {
        private readonly IEstateService _estateService;

        public EstateController(IEstateService estateService)
        {
            _estateService = estateService;
        }

        public ActionResult Index()
        {
            var estateList = _estateService.GetAll();
            var model = Mapper.Map<List<EstateModel>>(estateList);
            return View(model);
        }

        public ActionResult Edit(int? id)
        {
            var model = new EstateModel
            {
                ReleaseDate = DateTime.Today.ToShortDateString()
            };

            if (id != null)
            {
                var estateDto = _estateService.Get(id.Value);
                model = Mapper.Map<EstateModel>(estateDto);
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EstateModel model, HttpPostedFileBase ImageFile)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }

            if (ImageFile != null)
            {
                if (model.Image != null)
                {
                    var currentImagePath = Server.MapPath("~" + Constants.UploadPath + model.Image);

                    if (System.IO.File.Exists(currentImagePath))
                    {
                        System.IO.File.Delete(currentImagePath);
                    }
                }

                var imageName = Guid.NewGuid() + ".jpg";
                ImageFile.SaveAs(Server.MapPath("~" + Constants.UploadPath + imageName));
                model.Image = imageName;
            }

            var estateDto = Mapper.Map<EstateDto>(model);
            int id;

            if (model.EstateId == 0)
            {
                var result = _estateService.Add(estateDto);
                id = result.EstateId;
            }
            else
            {
                var result = _estateService.Update(estateDto);
                id = result.EstateId;
            }

            return RedirectToAction("Edit", new { id });
        }
    }
}
