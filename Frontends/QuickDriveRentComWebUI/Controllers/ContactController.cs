using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuickDriveRentCom.Dto.ContactDtos;
using System.Text;

namespace QuickDriveRentComWebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto)
        {
            var client = _httpClientFactory.CreateClient();
            createContactDto.SendDate = DateTime.Now; // gönderme tarihi şuan
            var jsonData = JsonConvert.SerializeObject(createContactDto); //text gelen alanı json türüne dönüştür
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json"); // utf8 karakterlerini json türünde sorunsuz kullanabilsin 
            var responseMessage = await client.PostAsync("https://localhost:7258/api/Contacts", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }
    }
}
