using TMPro;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Declarar Variables

    public string myName = "Miguel Angel";
    public int edad = 19;
    public bool isBool;

    [SerializeField] private TMP_InputField _inputfield;
    [SerializeField] private TMP_Text _saludo;
    [SerializeField] private Renderer _cubo;
    [SerializeField] private BoxCollider _BoxCollider;


    // Start is called before the first frame update
    void Start()
    {
        _cubo.material.color = Color.blue;
        _BoxCollider.isTrigger = false;



        myName = _inputfield.text;
        _saludo.text = "Hola " + myName;
    }

    // Update is called once per frame
    void Update()
    {
        myName = _inputfield.text;
        _saludo.text = "Hola " + myName;

    }
}
