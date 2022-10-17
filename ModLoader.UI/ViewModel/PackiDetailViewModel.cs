
using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;
using System.Collections.Generic;


namespace ModLoader.UI.ViewModel
{
    public class PackiDetailViewModel 
    {
        private IPackRepository _packRepository;

        public PackiDetailViewModel(IPackRepository packRepository)
        {
            _packRepository = packRepository;
        }
        public  void Create(string name, int parentId)
        {
            _packRepository.CreateOrSkip(new Pack { Name = name, ModCollectionId = parentId });
        }

        public  IEnumerable<Pack> GetAll()
        {
            return _packRepository.Get();
        }
    }
}
