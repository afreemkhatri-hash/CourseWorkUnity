using UnityEngine;

public class BeakerInteraction : MonoBehaviour
{
    private bool playerNear = false;

    public GameObject smokeEffect;

    public Renderer beakerRenderer;
    public Material normalMaterial;
    public Material greenMaterial;

    void Update()
    {
        if(playerNear && Input.GetKeyDown(KeyCode.E))
        {
            CheckReaction();
        }
    }

    void CheckReaction()
    {
        if (ChemicalManager.instance.pickedChemicals.Contains("Chemical A")
            && ChemicalManager.instance.pickedChemicals.Contains("Chemical B"))
        {
            UIManager.instance.ShowMessage("Reaction Success!");

            beakerRenderer.material = greenMaterial;
        }
        else
        {
            UIManager.instance.ShowMessage("Wrong Mixture");

            smokeEffect.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}