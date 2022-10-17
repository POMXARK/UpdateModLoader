
using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;
using System.Collections.Generic;


namespace ModLoader.UI.ViewModel
{
    public class ModCollectionDetailViewModel
    {
        private IModCollectionRepository _modCollectionRepository;

        public ModCollectionDetailViewModel(IModCollectionRepository modCollectionRepository)
        {
            _modCollectionRepository = modCollectionRepository;
        }

        public void Create(string name, int parentId)
        {
            _modCollectionRepository.CreateOrSkip(new ModCollection { Name = name, GamesId = parentId });
        }

        public IEnumerable<ModCollection> GetAll()
        {
            return _modCollectionRepository.Get();
        }
    }
}
