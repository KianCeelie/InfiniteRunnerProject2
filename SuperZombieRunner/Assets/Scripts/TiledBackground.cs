using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiledBackground : MonoBehaviour {

    public int TextureSize = 32;
    public bool ScaleHorizontally = true;
    public bool ScaleVertically = true;

	// Use this for initialization
	void Start () {

        var newWidth = !ScaleHorizontally ? 1 : Mathf.Ceil(Screen.width / (TextureSize * PixelPerfectCamera.scale));
        var newHeight = !ScaleVertically ? 1 : Mathf.Ceil(Screen.height / (TextureSize * PixelPerfectCamera.scale));

        transform.localScale = new Vector3(newWidth * TextureSize, newHeight * TextureSize, 1);

        GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth, newHeight, 1);

    }
	
}
