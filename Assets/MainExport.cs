using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainExport : MonoBehaviour
{
    public int resWidth = 2550; 
     public int resHeight = 3300;
 
     private bool takeHiResShot = false;
 
     public static string ScreenShotName(int width, int height) {
         return string.Format("/Users/bhsfic/MainCameraOutput/screen_{0}x{1}_{2}.png",  
                              width, height, 
                              System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
     }
 
 
     void LateUpdate() {
         if(Input.GetKeyDown("k")){
            takeHiResShot = !takeHiResShot;
         }
         if (takeHiResShot) {
             RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
             GetComponent<Camera>().targetTexture = rt;
             Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
             GetComponent<Camera>().Render();
             RenderTexture.active = rt;
             screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
             GetComponent<Camera>().targetTexture = null;
             RenderTexture.active = null; // JC: added to avoid errors
             Destroy(rt);
             byte[] bytes = screenShot.EncodeToPNG();
             string filename = ScreenShotName(resWidth, resHeight);
             System.IO.File.WriteAllBytes(filename, bytes);
             Debug.Log(string.Format("Took screenshot to: {0}", filename));
             //takeHiResShot = false;
         }
     }
    // Start is called before the first frame update
    void Start()
    {
        takeHiResShot = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
