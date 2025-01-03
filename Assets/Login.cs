using UnityEngine;

public class Login : MonoBehaviour
{
    private void OnMouseDown()
    {
        Application.OpenURL("https://localhost:7032/api/login/kakao");
    }
}