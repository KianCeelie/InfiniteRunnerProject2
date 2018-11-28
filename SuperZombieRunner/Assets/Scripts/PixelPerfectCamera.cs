using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour {

    public static float PixelToUnits = 1f;
    public static float scale = 1f;

    public Vector2 nativeresolution = new Vector2(240, 160);

	// Use this for initialization
	void Awake () {
        var camera = GetComponent<Camera>();

        if (camera.orthographic)
        {
            scale = Screen.height / nativeresolution.y;
            PixelToUnits *= scale;
            camera.orthographicSize = (Screen.height / 2.0f) / PixelToUnits;
        }
	}

}


