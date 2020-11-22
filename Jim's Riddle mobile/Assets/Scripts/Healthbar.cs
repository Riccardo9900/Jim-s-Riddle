using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{

    public Slider healthbarDisplay; //Display
    public float health = 100;

    public Color highHealthColor;
    public Color mediumHealthColor;
    public Color lowHealthColor;

    private void Start()
    {
        highHealthColor = new Color(0, 1f, 0); //vita verde
        mediumHealthColor = new Color(0.9450285f, 1f, 0.4481132f); //vita gialla
        lowHealthColor = new Color(1f, 0, 0); //vita rossa
    }

    // Every frame:
    private void Update()
    {
        healthbarDisplay.value = health;

        //Se ha un range di vita cambia colore alla barra
        if (healthbarDisplay.value <= 33)
        {
            ChangeHealthbarColor(lowHealthColor);
        }
        else if (healthbarDisplay.value > 33 && healthbarDisplay.value <= 66)
        {
            ChangeHealthbarColor(mediumHealthColor);
        }
    }

    public void ChangeHealthbarColor(Color colorToChangeTo)
    {
        GameObject.FindGameObjectWithTag("Bar").GetComponent<Image>().color = colorToChangeTo;
    }
}