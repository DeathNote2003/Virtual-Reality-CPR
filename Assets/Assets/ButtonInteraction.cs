using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInteraction : MonoBehaviour
{
    public string sceneToLoad;
    public KeyCode keyToPress; //  (T أو P) --> For Mouse 

    void Update()
    {
        // 
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

        
        if (Input.GetKeyDown(keyToPress))
        {
            Debug.Log("Key " + keyToPress + " pressed! Loading scene: " + sceneToLoad);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}