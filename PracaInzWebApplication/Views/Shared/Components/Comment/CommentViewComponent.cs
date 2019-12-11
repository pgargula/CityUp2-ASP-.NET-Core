using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models.ViewModels;
using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Views.Shared.Components.Comment
{
    public class CommentViewComponent : ViewComponent
    {
        private CommentViewModel _commentViewModel = new CommentViewModel();
        public async Task<IEnumerable<Models.Comment>> GetComments(int applicationId)
        {
            var uri = new Uri(Consts.appAdress + "api/ApiComment/GetComments/" + applicationId);
            try
            {
                using (HttpClient _httpClient = new HttpClient())
                {
                    var response = await _httpClient.GetAsync(uri);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return JsonConvert.DeserializeObject<IEnumerable<Models.Comment>>(await response.Content.ReadAsStringAsync());
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
            _commentViewModel.Comments = await GetComments(applicationId);
            return View("CommentView", _commentViewModel);
        }
    }
}
