using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuickDriveRentCom.Dto.AboutDtos;

namespace QuickDriveRentComWebUI.ViewComponents.AboutViewComponents
{
    public class _AboutUsComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

		public _AboutUsComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult>  InvokeAsync()
        {
            var client =_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7258/api/Abouts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync(); // apiden gelen veriyi string olarak okuyorum
				var values = JsonConvert.DeserializeObject < List<ResultAboutDto>>(jsonData) ; //jsonDatayı listDto verisine dönüştürdüm.
                return View(values);

            }
            return View();
        }
    }
}
