using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public Canvas reloadCanvas;
    public Button reloadButton;
    public GameObject Player;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            Debug.Log("Mort");
           
            // Afficher le Canvas
            reloadCanvas.gameObject.SetActive(true);

            // Activer le bouton de rechargement
            reloadButton.onClick.AddListener(ReloadLevel);

            Player.SetActive(false);
        
        }
    }

    private void ReloadLevel()
    {
        // Recharger le niveau actuel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }   
}
