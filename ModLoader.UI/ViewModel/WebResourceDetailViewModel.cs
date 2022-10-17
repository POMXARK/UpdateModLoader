using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;
using System.Collections.Generic;

namespace ModLoader.UI.ViewModel
{
    public class WebResourceDetailViewModel
    {
        private IWebResourceRepository _webResourceRepository;

        public WebResourceDetailViewModel(IWebResourceRepository webResourceRepository)
        {
            _webResourceRepository = webResourceRepository;
        }

        public  void Create(WebResource list)
        {
            _webResourceRepository.CreateOrSkip(list);
        }

        public  IEnumerable<WebResource> GetAll()
        {
            return _webResourceRepository.Get();
        }

    }
}
