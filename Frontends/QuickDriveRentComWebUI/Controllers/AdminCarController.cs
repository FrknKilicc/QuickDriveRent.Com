using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using QuickDriveRentCom.Dto.BrandDtos;
using QuickDriveRentCom.Dto.CarDtos;
using QuickDriveRentCom.Dto.ServiceDtos;
using System.Text;

namespace QuickDriveRentComWebUI.Controllers
{
    public class AdminCarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult>  Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7258/api/Cars/GetCarWithBrand");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarWithBrandsDtos>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult>  CreateCar()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7258/api/Brands");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBrandDto>>(jsonData);
                List<SelectListItem> brandValues=(from x in values
                                                  select new SelectListItem
                                                  {
                                                      Text=x.name,
                                                      Value=x.brandID.ToString(),
                                                  }).ToList();
                ViewBag.BrandValues= brandValues;
               
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarDto createCarDto)
        {
            var client= _httpClientFactory.CreateClient();
            var jsonData= JsonConvert.SerializeObject(createCarDto);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("https://localhost:7258/api/Cars/",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Bir Hata Oluştu");

        }
        public async Task<IActionResult> RemoveCar(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7258/api/Cars/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCar(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7258/api/Brands");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBrandDto>>(jsonData);
                List<SelectListItem> brandValues = (from x in values
                                                    select new SelectListItem
                                                    {
                                                        Text = x.name,
                                                        Value = x.brandID.ToString(),
                                                    }).ToList();
                ViewBag.BrandValues = brandValues;
            }
            var responseMessage1 = await client.GetAsync($"https://localhost:7258/api/Cars/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData1= await responseMessage1.Content.ReadAsStringAsync();
                var values1 = JsonConvert.DeserializeObject<UpdateCarDto>(jsonData1);
                return View(values1);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCar(UpdateCarDto updateCarDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateCarDto);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("https://localhost:7258/api/Cars/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
