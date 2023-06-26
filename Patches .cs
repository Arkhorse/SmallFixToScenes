using UnityEngine;
using Il2Cpp;

namespace SmallFixToScenes
{
    public class Patches : MonoBehaviour                               //public class Patches:MonoBehaviour
    {
        /*
        public struct fixdata
        {
            public bool Delete;
            public string Scene;
            public string Name;
            public int EulerY;
        }
        private List<fixdata> fL_ = new List<fixdata>();
        */

        public static string[,] itemDataArray =
        {
            {"0_Delete","1_Scene",              "2_Name",                               "3_EulerY", "4_Position" },
            {"false",   "CrashMountainRegion",  "STR_StoneCabinA_Prefab/TRIGGER_IndoorSpace",              "0",        "0"},
            {"false",   "CrashMountainRegion",  "STR_StoneCabinATrapDoor",              "0",        "0"},
            {"false",   "CrashMountainRegion",  "INTERACTIVE_BedMattressB",             "0",        "890.3362,160.6400,341.8036"},       //item = INTERACTIVE_BedMattressB p = 890.3362,160.6400,341.8036 r = 0.0000,90.3298,0.0000 c = 100

            {"false",   "CrashMountainRegion",  "INTERACTIVE_WorkBench",                "0",        "0"},       //item = INTERACTIVE_WorkBench p=886.7240,161.1370,344.1470 r=0.0000,85.3432,0.0000 c=100
            {"false",   "CrashMountainRegion",  "StoneCabinStuff/CONTAINER_FirstAidKitB","0",       "891.0700,160.7100,342.5940"},        //item = CONTAINER_FirstAidKitB p=891.0700,160.7100,342.5940 r=270.3867,127.7562,309.6633 c=100

            {"false",   "CrashMountainRegion",  "STR_StoneCabinAShutterRight_Prefab",   "175" ,     "0"},
            {"false",   "CrashMountainRegion",  "STR_StoneCabinAShutterLeft_Prefab",    "175" ,     "0"},

            {"false",   "CoastalRegion",        "INTERACTIVE_BedMattressB",             "98",       "357.2500,203.2560,1155.4300"},     // p=357.2500,203.2560,1155.4300 r=0.0000,97.6586,0.0000 c=100
            {"false",   "CoastalRegion",        "CONTAINER_Cupboard",                   "43",       "354.138, 203.691, 1156.432"},         //

            {"false",   "LakeRegion",        "INTERACTIVE_BunkBed",             "180.0005",       "789.6909, 212.9654, 966.4996"},
            {"false",   "LakeRegion",        "OBJ_CounterShort_Prefab",             "90",       "786.1348, 212.9763, 967.1045"},
            {"false",   "LakeRegion",        "OBJ_CupA_Prefab",             "131.3085",       "786.1907, 214.173, 967.4338"},
            {"false",   "LakeRegion",        "OBJ_CupA_Prefab",             "0.0001, 192.0052, -0",       "786.0354, 214.13, 967.5464"},
            {"false",   "LakeRegion",        "OBJ_BasinA_Prefab",             "6.9869, 352.9229, 0",       "786.2968, 213.4794, 966.7321"},
            {"false",   "LakeRegion",        "OBJ_BasinA_Prefab",             "352.9229",       "786.2968, 213.4154, 966.7321"},
            {"false",   "LakeRegion",        "OBJ_PitcherA_Prefab",             "25.48",       "786.1748, 214.116, 967.268"},
            {"false",   "LakeRegion",        "INTERACTIVE_RadioA",             "261.6048",       "786.1396, 213.0193, 966.606"},

            {"false",   "LakeRegion",        "OBJ_CounterCorner_Prefab",             "180.0016",       "791.1887, 212.9964, 969.7589"},
            {"false",   "LakeRegion",        "OBJ_CupA_Prefab",             "97.1377",       "790.7213, 213.4554, 969.4648"},
            {"false",   "LakeRegion",        "OBJ_CupA_Prefab",             "97.1377",       "790.5533, 213.4554, 969.5096"},
            {"false",   "LakeRegion",        "OBJ_SoapA_Prefab",             "359.5456, 65.2828, 0.9724",       "790.9919, 214.1484, 969.2787"},

            {"false",   "CanneryRegion_SANDBOX",        "INTERACTIVE_BedMattressB",             "116.410",       "299.446, 239.029, 350.7729"},
            {"false",   "CanneryRegion_SANDBOX",        "CONTAINER_BathroomCabinetA",             "116.4107",       "299.0701, 238.884, 353.907"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CounterShort_Prefab",             "206.410",       "299.701, 239.015, 351.533"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CounterCorner_Prefab",             "296.4107",       "300.265, 239.015, 347.517"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CupA_Prefab (6)",             "0, 7.5708, 95.039",       "299.865, 240.067, 351.3651"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CupE_Prefab (5)",             "27.2928",       "299.994, 240.01, 351.207"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (2)",             "0",       "299.544, 239.424, 351.598"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (3)",             "359.5615, 1.5627, 2.8393",       "299.555, 239.443, 351.598"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_PitcherA_Prefab (2)",             "325.2213",       "298.642, 239.974, 354.0001"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CupA_Prefab (7)",             "0",       "299.524, 240.3037, 353.85"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_CupA_Prefab (8)",             "277.3769",       "299.391, 240.3037, 353.955"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (4)",             "355.4505, 215.848, 359.2446",       "298.952 240.357 354.0861"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (5)",             "116.4107",       "298.956, 240.332, 354.0941"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishServeB3_Prefab (6)",             "320.9328",       "298.765, 240.584, 354.16"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_SoapA_Prefab",             "13.9255",       "299.33, 239.99, 353.622"},
            {"false",   "CanneryRegion_SANDBOX",        "OBJ_DishBowlA_LOD0",             "0",       "299, 240.044, 353.783"},

            {"false",   "BlackrockRegion",        "INTERACTIVE_BedMattressD",             "192.9915",       "903.2423, 231.4615, -100.397"},
            {"false",   "BlackrockRegion",        "CONTAINER_SmallCabinetB",             "345.4815",       "899.0304, 231.4896, -100.777"},
            {"false",   "BlackrockRegion",        "STR_StoneCabinADoor_Prefab",             "327.1487",       "897.7574, 231.4832, -99.706"},
        };

        public static void ChangeObjcets()
        {

            GameObject findTargetGO = new GameObject();

            // EY === Euler_Y
            float MHShutterRight_EY = 187.4753f;
            float MHShutterLeft_EY = 129.4225f;
            float MHShutterRight_EY_Close = 175f;
            float MHShutterLeft_EY_Close = 175f;
            float MHShutterRight_EY_Open = 305f;
            float MHShutterLeft_EY_Open = 45f;

            //float MHShutterRightlocal_EY = 102.0222f;       
            //float MHShutterLeftlocal_EY = 43.9695f;         

            Vector3 MHFAkitPos = new Vector3(891.0700f, 160.7100f, 342.5940f);
            Quaternion MHFAkitRot = Quaternion.Euler(270.3867f, 127.7562f, 309.6633f);

            /*
             * struct
             * 
            fL_.Add(new fixdata { Delete = false, Scene = "CrashMountainRegion", Name = "STR_StoneCabinAShutterRight_Prefab", EulerY = 175  });
            fL_.Add(new fixdata { Delete = false, Scene = "CrashMountainRegion", Name = "STR_StoneCabinAShutterLeft_Prefab", EulerY = 175 });
            //item = INTERACTIVE_BedMattressB p = 890.3362,160.6400,341.8036 r = 0.0000,90.3298,0.0000 c = 100
            fL_.Add(new fixdata { Delete = false, Scene = "CrashMountainRegion", Name = "INTERACTIVE_BedMattressB", EulerY = 0 });
            //item = INTERACTIVE_BedMattressB p = 890.7637,160.6400,343.6804 r = 0.0000,172.8061,0.0000 c = 100
            fL_.Add(new fixdata { Delete = true,  Scene = "CrashMountainRegion", Name = "INTERACTIVE_BedMattressB", EulerY = 0 });
            */

            for (int i = 1; i < itemDataArray.GetLength(0); i++)
            {
                // ----- Find Name -----------------------------------------------------------------
                if (GameObject.Find(itemDataArray[i, 2]) == null)
                {
                    //MelonLogger.Msg("ChangeObjcet is null.");
                    continue;
                }
                else
                {
                    findTargetGO = GameObject.Find(itemDataArray[i, 2]);
                    // GameObject.Find cannot find for already inactive game objects. So this needs to be reloaded after confermation.
                }
                // -------------------------------------------------------------------------------------


                if (findTargetGO != null)
                {
                    // ----- Scene check -----------------------------------------------------------------
                    if (findTargetGO.scene.name != itemDataArray[i, 1]) // Scene 
                    {
                        //MelonLogger.Msg("Scene name does not match.");
                        continue;
                    }
                    // -------------------------------------------------------------------------------------

                    /*
                    string nameposi = findTargetGO.transform.name +"_"+ findTargetGO.transform.position.x +"_"+ findTargetGO.transform.position.y + "_" + findTargetGO.transform.position.z;
                    MelonLogger.Msg(findTargetGO.name + " : for , i = " + i + " - " + nameposi);

                    Transform fTGOTrf = findTargetGO.transform.parent;
                    if (fTGOTrf == null)
                    {
                        //MelonLogger.Msg(" ---------- gearsTrf null");
                        continue;
                    }
                    */

                    // ==============================================================================================================
                    // Timberwolf Mountain, CrashMountainRegion 
                    // ==============================================================================================================

                    if (itemDataArray[i, 1] == "CrashMountainRegion")
                    {

                        // Windows --------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "STR_StoneCabinAShutterRight_Prefab") // Window Right  
                        {
                            switch (Settings.options.TMMHWindows)
                            {
                                case 0: //default
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterRight_EY, 0);
                                    break;
                                case 1: //open
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterRight_EY_Open, 0);
                                    break;
                                case 2: //close
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterRight_EY_Close, 0);
                                    break;
                            }
                        }
                        if (itemDataArray[i, 2] == "STR_StoneCabinAShutterLeft_Prefab") // Window Left  
                        {
                            switch (Settings.options.TMMHWindows)
                            {
                                case 0: //default
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterLeft_EY, 0);
                                    break;
                                case 1: //open
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterLeft_EY_Open, 0);
                                    break;
                                case 2: //close
                                    findTargetGO.transform.rotation = Quaternion.Euler(0, MHShutterLeft_EY_Close, 0);
                                    break;
                            }
                        }
                        // ------------------------------------------------------------------------------------------


                        // FirstAidKitB ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "StoneCabinStuff/CONTAINER_FirstAidKitB")
                        {
                            if (Settings.options.TMMHRemoveFAKit)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }

                            if (Settings.options.TMMHMoveFAKit)
                            {
                                findTargetGO.transform.position = new Vector3(
                                    Settings.options.TMMHFAKPosX,
                                    Settings.options.TMMHFAKPosY,
                                    Settings.options.TMMHFAKPosZ
                                );
                                findTargetGO.transform.rotation = Quaternion.Euler(
                                    Settings.options.TMMHFAKRotX,
                                    Settings.options.TMMHFAKRotY,
                                    Settings.options.TMMHFAKRotZ
                                );
                            }
                            else
                            {
                                findTargetGO.transform.position = MHFAkitPos; //MHFAkitPos.x = 891.0700f; MHFAkitPos.y = 160.7100f; MHFAkitPos.z = 342.5940f;
                                findTargetGO.transform.rotation = MHFAkitRot; //Quaternion.Euler(270.3867f, 127.7562f, 309.6633f);
                            }
                        }
                        // ------------------------------------------------------------------------------------------


                        // Bed MH ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressB")
                        {
                            if (Settings.options.TMMHRemoveBeds && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------


                        // WorkBench ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "INTERACTIVE_WorkBench")
                        {
                            if (Settings.options.TMMHRemoveWorkbench)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_StoneCabinATrapDoor")
                        {
                            if (Settings.options.TMMHCloseRoof)
                            {
                                if (GameObject.Find("STR_StoneCabinATrapDoor(Clone)"))
                                {
                                    continue;
                                }
                                else
                                {
                                    GameObject cloneObject = Instantiate(  // #Instantiate: clone to gameobject (MonoBehaviour)
                                        findTargetGO,
                                        new Vector3(887f, 164.7f, 343.2f),
                                        Quaternion.Euler(0f, 175f, 325f)
                                        );
                                    cloneObject.transform.localScale = new Vector3(3f, 0.5f, 2f);
                                }
                            }
                            else
                            {
                                if (GameObject.Find("STR_StoneCabinATrapDoor(Clone)"))
                                {
                                    Destroy(GameObject.Find("STR_StoneCabinATrapDoor(Clone)"), 0.5f);
                                }
                            }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Indoor Temp ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_StoneCabinA_Prefab/TRIGGER_IndoorSpace")
                        {
                            findTargetGO.GetComponent<IndoorSpaceTrigger>().m_TemperatureDeltaCelsius = Settings.options.TMMHTemp;
                        }
                        // ------------------------------------------------------------------------------------------

                    }

                    // ==============================================================================================================
                    // Coastal Highway 
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "CoastalRegion")
                    {

                        // Bed CH_AL ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressB")
                        {

                            if (Settings.options.CHALRemoveBeds && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Cupboard ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_Cupboard")
                        {
                            if (Settings.options.CHALRemoveCupBoard)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                    }
                    // ------------------------------------------------------------------------------------------

                    // ==============================================================================================================
                    // Mystery Lake
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "LakeRegion")
                    {

                        // Bed ML_FL ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_BunkBed")
                        {

                            if (Settings.options.MLFLRemoveBeds && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CounterShort_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_BasinA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_BasinA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_PitcherA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "INTERACTIVE_RadioA")
                        {
                            if (Settings.options.MLFLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CounterCorner_Prefab")
                        {
                            if (Settings.options.MLFLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_SoapA_Prefab")
                        {
                            if (Settings.options.MLFLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                    }
                    // ==============================================================================================================
                    // Bleak Inlet
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "CanneryRegion_SANDBOX")
                    {

                        // Bed BI_PL ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressB")
                        {

                            if (Settings.options.BIPLRemoveBeds && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Cabinet ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_BathroomCabinetA")
                        {
                            if (Settings.options.BIPLRemoveCabinet)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Short Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CounterShort_Prefab")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab (6)")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_CupE_Prefab (5)")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (2)")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (3)")
                        {
                            if (Settings.options.BIPLRemoveShortCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Corner Counter ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "OBJ_CounterCorner_Prefab")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_PitcherA_Prefab (2)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab (7)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_CupA_Prefab (8)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (4)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (5)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishServeB3_Prefab (6)")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_SoapA_Prefab")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        if (itemDataArray[i, 2] == "OBJ_DishBowlA_LOD0")
                        {
                            if (Settings.options.BIPLRemoveCornerCounter)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                    }
                    // ==============================================================================================================
                    // Black Rock
                    // ==============================================================================================================
                    if (itemDataArray[i, 1] == "BlackrockRegion")
                    {

                        // Bed BRR_PL ------------------------------------------------------------------------------------------

                        if (itemDataArray[i, 2] == "INTERACTIVE_BedMattressD")
                        {

                            if (Settings.options.BRRBLRRemoveBeds && findTargetGO.scene.name == itemDataArray[i, 1])
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                        // ------------------------------------------------------------------------------------------

                        // Cabinet ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "CONTAINER_SmallCabinetB")
                        {
                            if (Settings.options.BRRBLRRemoveCabinet)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }

                        // Door ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 2] == "STR_StoneCabinADoor_Prefab")
                        {
                            if (Settings.options.BRRBLRRemoveDoor)
                            { findTargetGO.SetActive(false); }
                            else
                            { findTargetGO.SetActive(true); }
                        }
                    }


                    
                }
            }

        }

    }

}