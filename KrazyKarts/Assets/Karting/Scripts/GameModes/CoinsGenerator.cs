using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsGenerator : MonoBehaviour
{
    public GameObject Track;
    public List<GameObject> CoinsCollectionModules;

    [Tooltip("Total track modules that will instantiate coins")]
    public int tracksWithCoins = 3;

    List<Transform> selectedTracksList = new List<Transform>();

    // Start is called before the first frame update
    void Awake()
    {
        selectedTracksList = GetRandomModules();
        float offsetY = 1.5f;
        for (int i = 0; i < selectedTracksList.Count; i++)
        {
            Vector3 coinPosititon = new Vector3(selectedTracksList[i].transform.position.x, selectedTracksList[i].transform.position.y + offsetY, selectedTracksList[i].transform.position.z);

            int selectedCoinsCollection = Random.Range(0, CoinsCollectionModules.Count);
            GameObject.Instantiate(CoinsCollectionModules[selectedCoinsCollection], coinPosititon, CoinsCollectionModules[selectedCoinsCollection].transform.rotation);
        }        
    }

    // Adrian: seleccionar tantos módulos como indique tracksWithCoins de manera random
    List<Transform> GetRandomModules()
    {
        int totalTrackModules = Track.transform.childCount;
        List<Transform> totalTracksList = new List<Transform>();        

        for (int i = 0; i < totalTrackModules; i++)
        {
            // obtenemos todos los modulos en escena y descartamos aquellos donde no queramos instanciar CoinsColecctions (metodo provisional)
            Transform module = Track.transform.GetChild(i);
            string moduleName = module.gameObject.name;

            if (moduleName != "ModularTrackStraight(1)" && moduleName != "ModularTrackStraight(2)" && moduleName != "ModularTrackStraight(16)")
            totalTracksList.Add(Track.transform.GetChild(i));
        }
        for (int i = 0; i < tracksWithCoins; i++)
        {
            selectedTracksList.Add(totalTracksList[Random.Range(0, totalTracksList.Count)]);
        }
        
        return selectedTracksList;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
