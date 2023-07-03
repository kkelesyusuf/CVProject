using CV.Models.Entity;
using CV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CV.Controllers
{
    public class CertificateController : Controller
    {
        // GET: Certificate
        DBCvEntities dB = new DBCvEntities();
        GenericRepository<Certificates> repository = new GenericRepository<Certificates>();
        public ActionResult Index()
        {
            var values = repository.GetList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateCertificate(int id)
        {
            var certificate = repository.GetByID(x => x.ID == id);
            return View(certificate);
        }
        [HttpPost]
        public ActionResult UpdateCertificate(Certificates t)
        {
            return View();
        }
    }
}