
using ModLoader.Model;
using ModLoader.UI.Data.Repositories.Interfaces;
using System.Collections.Generic;


namespace ModLoader.UI.ViewModel
{
    public class ModDetailViewModel
    {
        private IModRepository _modRepository;

        public ModDetailViewModel(IModRepository modRepository)
        {
            _modRepository = modRepository;
        }
        public  void Create(string name, int parentId)
        {
            _modRepository.CreateOrSkip(new Mod { Name = name, PackId = parentId });
        }

        public  IEnumerable<Mod> GetAll()
        {
            return _modRepository.Get();
        }
    }
}
