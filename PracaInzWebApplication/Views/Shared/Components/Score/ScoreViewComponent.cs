using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Views.Shared.Components.Score
{
    public class ScoreViewComponent : ViewComponent
    {
        private  ScoreViewModel _scoreViewModel = new ScoreViewModel();
        public async Task<ScoreViewModel> GetScore(int applicationId, int userId)
        {
            var uri = new Uri(Consts.appAdress + "api/ApiApplication/GetScore/" + applicationId+"/"+userId);
            try
            {
                using (HttpClient _httpClient = new HttpClient())
                {
                    var response = await _httpClient.GetAsync(uri);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return JsonConvert.DeserializeObject<ScoreViewModel>(await response.Content.ReadAsStringAsync());
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<IViewComponentResult> InvokeAsync(int applicationId)
        {
            var user = User as ClaimsPrincipal;
            var userId = Convert.ToInt32(user.Claims.FirstOrDefault(x => x.Type == "Id").Value);
            _scoreViewModel = await GetScore(applicationId, userId);
            return View("ScoreView",_scoreViewModel);
        }
    }
}
