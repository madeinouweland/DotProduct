using UnityEngine;
using UnityEngine.UI;

public class DotProduct : MonoBehaviour
{
    public Text Text;
    public GameObject Hero;
    public GameObject Villain;

    private void Update()
    {
        CalculateDotProduct();
    }

    private void CalculateDotProduct()
    {
        var text = "";

        var heroForward = Hero.transform.forward;
        var youToVillain = Villain.transform.position - Hero.transform.position;

        text += "\nForward x[" + heroForward.x + "] z[" + heroForward.z + "]";
        text += "\nYou to villain x[" + youToVillain.x + "] z[" + youToVillain.z + "]";

        var dot = CalculateDotProduct(heroForward, youToVillain);

        text += "\nDot " + dot;
        if (dot >= 0)
        {
            text += "\nVillain is in front of hero";
        }
        else
        {
            text += "\nVillain is behind hero";
        }
        Text.text = text;
    }

    private float CalculateDotProduct(Vector3 v1, Vector3 v2)
    {
        return v1.x * v2.x + v1.z * v2.z; // ignore Y-axis
    }
}
