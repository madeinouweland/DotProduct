using UnityEngine;

public class VillainController : MonoBehaviour
{
    public GameObject Hero;
    public GameObject Villain;
    private CharacterController _controller;

    private void Start()
    {
        _controller = Villain.GetComponent<CharacterController>();   
    }

    private void Update()
    {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");

        var direction = new Vector3(hor, 0, ver);
        _controller.Move(direction*.2f);

        Villain.transform.LookAt(Hero.transform);
    }
}
