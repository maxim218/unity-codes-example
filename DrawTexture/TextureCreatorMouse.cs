using UnityEngine;

public class TextureCreator : MonoBehaviour
{
    // colors
    [SerializeField] private Color firstColor = Color.white;
    [SerializeField] private Color secondColor = Color.white;
    
    // texture
    private Texture2D _texture = null;
    
    // camera
    [SerializeField] private Camera myCamera = null;
    
    // resolution
    private const int Resolution = 16;
    
    private void Start()
    {
        // component
        Renderer rendererScript = GetComponent<Renderer>();

        // size
        const int width = Resolution;
        const int height = Resolution;
        
        // create
        Texture2D texture = new Texture2D(width, height);
        
        // filter
        texture.filterMode = FilterMode.Point;
        
        // wrap
        texture.wrapMode = TextureWrapMode.Clamp;

        // component set texture
        rendererScript.material.mainTexture = texture;
        
        // paint grid
        for (int i = 0; i < Resolution; i++)
            for (int k = 0; k < Resolution; k++)
                texture.SetPixel(i, k, firstColor);

        // apply
        texture.Apply();
        
        // field set
        _texture = texture;
    }

    private void OnMouseDown()
    {
        // ray control
        Ray ray = myCamera.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out RaycastHit hit)) return;
        
        // calc pos
        int x = (int) (Resolution * hit.textureCoord.x);
        int y = (int) (Resolution * hit.textureCoord.y);
            
        // pixel change
        _texture.SetPixel(x, y, secondColor);
        _texture.Apply();

        // write message
        string message = "Position: " + x + " " + y;
        Debug.Log(message);
    }
}
