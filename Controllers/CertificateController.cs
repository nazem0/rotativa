using API.Models;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using Rotativa.AspNetCore.Options;
using System.Net.Mime;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        [HttpGet]
        public IActionResult GenerateCertificate([FromQuery] CreateCertificate model)
        {
            Certificate certificate = new()
            {
                IssuanceDate = model.IssuanceDate,
                ExpirationDate = model.ExpirationDate,
                Issuer = model.Issuer,
                RecipientName = model.RecipientName,
                Course = model.Course

            };

            ViewAsPdf certificateView = new()
            {
                Model = certificate,
                ViewName = "Certificate",
                PageOrientation = Orientation.Landscape,
                PageSize = Size.A4
            };

            return certificateView;
            //byte[] certificateFile = await certificateView.BuildFile(ControllerContext);

            //return new FileContentResult(certificateFile, MediaTypeNames.Application.Pdf)
            //{
            //    FileDownloadName = $"{certificate.RecipientName} Certificate.pdf"
            //};
        }
    }
}
