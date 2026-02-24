
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Rigidbody2D _rb2D;
    [SerializeField] private float x = 0;
    public float velocidad = 10f;

    private  void Start()
    {
        //_transform.position = new Vector3(12.11, 3.18645f, 0); 
    }

    private void FixedUpdate()
    {
       
        _rb2D.velocity = Vector2.right * velocidad;

    }
}
