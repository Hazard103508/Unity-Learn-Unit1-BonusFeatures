using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    private float circumference;
    // Start is called before the first frame update
    void Start()
    {
        var render = this.GetComponent<MeshRenderer>();
        var diametro = render.bounds.size.y;
        circumference = Mathf.PI * diametro;
    }

    public void Rotate(float speed)
    {
        float displacement = Time.deltaTime * speed;
        float angle = (displacement * 360) / this.circumference; // Rotacion de las ruedas segun la velocidad
        this.transform.Rotate(Vector3.right * angle);
    }
}
