using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInteraction : MonoBehaviour
{
    public string sceneToLoad;
    public KeyCode keyToPress; // زرار الكيبورد (T أو P)

    void Update()
    {
        // تحقق إذا الماوس فوق الكائن وبضغط زرار الماوس الأيسر
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    Debug.Log("Clicked on " + gameObject.name + "! Loading scene: " + sceneToLoad);
                    SceneManager.LoadScene(sceneToLoad);
                }
            }
        }

        // تحقق إذا الزر المرتبط تم الضغط عليه
        if (Input.GetKeyDown(keyToPress))
        {
            Debug.Log("Key " + keyToPress + " pressed! Loading scene: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}