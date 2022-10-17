using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;
using System.Collections.Generic;


namespace ModLoader.UI.ViewModel
{
    public class GamesDetailViewModel
    {
        private IGamesRepository _gamesRepository ;

        public GamesDetailViewModel(IGamesRepository gamesRepository)
        {
            _gamesRepository = gamesRepository;
        }

        public void Create(string name)
        {
            _gamesRepository.CreateOrSkip(new Games { Name = name });
        }

        public IEnumerable<Games> GetAll()
        {
            return _gamesRepository.Get();
        }
    }
}
