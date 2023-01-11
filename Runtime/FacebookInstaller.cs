using Zenject;

namespace LittleBitGames.FacebookModule
{
    public class FacebookInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container
                .Bind<FacebookInitService>()
                .AsSingle()
                .NonLazy();
        }
    }
}