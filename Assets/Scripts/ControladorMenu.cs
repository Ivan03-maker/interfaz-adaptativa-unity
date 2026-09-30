using UnityEngine;

public class ControladorMenu : MonoBehaviour
{
    public GameObject canvasMenuPrincipal;
    public GameObject canvasTrabajo;

    // Método para ir al área de trabajo
    public void IrACanvasTrabajo()
    {
        if (canvasMenuPrincipal != null)
            canvasMenuPrincipal.SetActive(false);

        if (canvasTrabajo != null)
            canvasTrabajo.SetActive(true);
    }

    // Método para regresar al menú principal
    public void RegresarAlMenu()
    {
        if (canvasTrabajo != null)
            canvasTrabajo.SetActive(false);

        if (canvasMenuPrincipal != null)
            canvasMenuPrincipal.SetActive(true);
    }
}