using UnityEngine;

public class TextureCreator : MonoBehaviour
{
    // colors
    [SerializeField] private Color firstColor = Color.white;
    [SerializeField] private Color secondColor = Color.white;
    
    private void Start()
    {
        // component
        Renderer rendererScript = GetComponent<Renderer>();

        // size
        const int resolution = 16;
        const int width = resolution;
        const int height = resolution;
        
        // create
        Texture2D texture = new Texture2D(width, height);
        
        // filter
        texture.filterMode = FilterMode.Point;
        
        // wrap
        texture.wrapMode = TextureWrapMode.Clamp;

        // component set texture
        rendererScript.material.mainTexture = texture;
        
        // flag
        bool flag = true;

        // paint grid
        for (int i = 0; i < resolution; i++)
        {
            flag = !flag;
            for (int k = 0; k < resolution; k++)
            {
                flag = !flag;
                Color color = flag ? firstColor : secondColor;
                int x = i;
                int y = k;
                texture.SetPixel(x, y, color);
            }
        }
        
        // apply
        texture.Apply();
    }
}
