using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class ScreenLoader : LocalAssetLoader
{
    public Task<BaseScreen> InstantiateAsync(AssetReferenceGameObject screen, Transform transform) 
    {
        return InstantiateAsync<BaseScreen>(screen, transform);
    }

    public void Unload() 
    {
        UnloadInternal();
    }
}
