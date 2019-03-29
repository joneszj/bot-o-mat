using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.API.Models;
using System.Linq;

namespace CommonPatterns.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    public class LogsController : Controller
    {
        #region ctor && private
        private string _filepath;
        private string _filepathCopy;

        [Route("Logs")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(new LogsIndexViewModel { Files = System.IO.Directory.GetFiles("_Logs").OrderByDescending(e => e).Take(100).ToArray() });
        } 
        #endregion

        /// <summary>
        /// yyyymmdd
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        [Route("Logs/{date}")]
        [HttpGet]
        public FileResult Download(string date)
        {
            _filepath = $"_Logs/log_{date}.txt";
            _filepathCopy = $"_Logs/log_{date}_copy.txt";
            if (System.IO.File.Exists(_filepathCopy)) System.IO.File.Delete(_filepathCopy);
            System.IO.File.Copy(_filepath, _filepathCopy);
            byte[] fileBytes = System.IO.File.ReadAllBytes(_filepathCopy);
            System.IO.File.Delete(_filepathCopy);
            return File(fileBytes, ContentTypes.Download, $"log_{date}.txt");
        }
    }
}