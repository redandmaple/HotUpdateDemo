using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    public RawImage img;
    void Start()
    {
        Addressables.LoadAssetAsync<Texture2D>("Assets/Textures/м©и╫яеяе.png").Completed +=(handle) =>
        {
            
            Texture2D image = handle.Result;
            img.texture = image;
            img.GetComponent<RectTransform>().sizeDelta = new Vector2(image.width, image.height);
        };
    }
}
