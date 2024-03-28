using BlazorPDFReport;
using Microsoft.AspNetCore.Mvc;

namespace ProSoft.Controllers
{
    public class GeneratePDFController : Controller
    {
        [HttpGet("DownloadPdf")]
        public IActionResult DownloadPDFFile(string pageName)
        {
            var PDF = new GeneratePDF($"http://{Request.Host.Value}/{pageName}");
            var PDFFile = PDF.GetPDF();
            var PDFStream = new MemoryStream(PDFFile);
            return new FileStreamResult(PDFStream, "application/pdf");
        }
    }
}
