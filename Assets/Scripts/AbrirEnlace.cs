using UnityEngine;

public class AbrirEnlace : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void AbrirSitioWeb(string url)
    {
        Application.OpenURL(url);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
