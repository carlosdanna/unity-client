using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Net;
using System.IO;

[System.Serializable]
class TestModel 
{

    public string Test;
    public int Description;

    public TestModel() 
    {
        Test = "";
        Description = 0;
    }
     
    
    public static TestModel CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<TestModel>(jsonString);
    }

    
    public static TestModel CreateFromJson(string p)
    {
        return JsonUtility.FromJson<TestModel>(p);
    }
}


public class ConnectionController : MonoBehaviour {

    public Text[] uiText;
	// Use this for initialization
    
    private TestModel testModel;

    IEnumerator CallServer() {
        print("enter corroutine");
        WWW data = new WWW("http://localhost:3000/data");
        yield return new WaitForSeconds(1.0f);
        print(data);
        print(data.text);
        testModel = TestModel.CreateFromJSON(data.text);
        uiText[0].text = data.text;
        uiText[1].text = testModel.Test;
        uiText[2].text = testModel.Description.ToString();
        uiText[3].text = "Aleluja!!!";
        print(testModel);
        
        
    }

    

    //private void readJsonResponse(string p)
    //{
    //    print(p);
    //    testModel = TestModel.CreateFromJSON(p.ToString());
    //    uiText[0].text = p;
    //    uiText[1].text = testModel.Test;
    //    print(testModel.Test);
        
    //}
	void Start () {
	    //make the api calls here
        StartCoroutine(CallServer());
	}
	
	// Update is called once per frame
	void Update () {
	    //if there are many whenever press spacebar go to the next one in the array
        if (Input.GetKeyDown(KeyCode.Space)) {
            print("space");
            
        }
	}
}
