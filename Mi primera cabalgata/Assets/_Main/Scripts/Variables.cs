using TMPro;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Declarar Variables

    public string myName = "Miguel Angel";
    public int edad = 19;

    [SerializeField] private TMP_InputField _inputfield;
    [SerializeField] private TMP_Text _saludo;


    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        myName = _inputfield.text;
        _saludo.text = "Hola " + myName;

    }
}
