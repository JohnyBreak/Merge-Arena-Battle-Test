using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LocalAssetLoader
{
    private GameObject _cachedObject;

    protected async Task<T> LoadInternal<T>(string assetId) 
    {
        var handle = Addressables.InstantiateAsync(assetId);
        _cachedObject = await handle.Task;
        if (_cachedObject.TryGetComponent(out T required) == false)
            throw new NullReferenceException($"object of type {typeof(T)} is null on attempt to load from addressables");

        return required;
    }

    protected async Task<T> InstantiateAsync<T>(AssetReferenceGameObject asset, Transform transform)
    {
        var handle = Addressables.InstantiateAsync(asset, transform);
        _cachedObject = await handle.Task;
        if (_cachedObject.TryGetComponent(out T required) == false)
            throw new NullReferenceException($"object of type {typeof(T)} is null on attempt to load from addressables");

        return required;
    }

    protected void UnloadInternal() 
    {
        if (_cachedObject == null) return;

        _cachedObject.SetActive(false);
        Addressables.ReleaseInstance(_cachedObject);
        _cachedObject = null;
    }
}
