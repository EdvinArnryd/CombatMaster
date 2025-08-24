using Unity.VisualScripting;
using UnityEngine;
using MouseButton = UnityEngine.InputSystem.LowLevel.MouseButton;

public class CharacterControl : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("Mouse clicked");
        }
    }
}
