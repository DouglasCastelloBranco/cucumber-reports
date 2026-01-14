using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PersisteToServer
{
    public Dictionary<string, object> Results;
    public string LastError;
    public string SoftFail;
    public Dictionary<string, object> SoftFailVars;
    public string HardFail;

    public IEnumerator Go(string action, Dictionary<string, object> postVars = null, int retries = 5, int retryWait = 2)
    {
        Debug.Log($"[POST][BODY]: endpoint={action}, postVars={CF_761e4a3ab9b969f3e114c40a3160728194081507.Serialize(postVars)}");
        yield return CEMisc.StartCoroutineStatic(PostWithRetry(action, postVars, retries, retryWait));
    }

    private IEnumerator PostWithRetry(string action, Dictionary<string, object> postVars, int retries, int retryWait)
    {
        if (CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_910cdcbd911596895370fa53dd8b86b68ec0d71c == null ||
            CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_f7a715da1100f7016fbcf8386b75c7afe50e9b8b == null)
        {
            Debug.LogError(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64030));
            yield break;
        }

        CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_5e66d4818305611f03e248f8dc63ed32c48104c7++;

        string antiCache = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64117) +
                           CEMisc.Rand(150533, 150537).ToString();
        if (action.IndexOf(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1256)) > 150541)
        {
            antiCache = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1236) + antiCache;
        }
        else
        {
            antiCache = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1256) + antiCache;
        }

        postVars ??= new Dictionary<string, object>();

        Dictionary<string, object> localData = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_5de020f6681224f534d74fd1c18e6e14780e7ddb();
        postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)] = CEMisc.CF_e57c757547290c33f0657c5a5f6b9c6c92edfc80();
        if (localData.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)))
        {
            postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)] =
                Convert.ToDouble(localData[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)]);
        }
        postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1181)] =
            (string)localData[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1210)];

        string hashString = BuildHashString(postVars);
        hashString = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_a0ec4a3dd83c68475df0ec7973cbe1a272f3ed39(
            hashString,
            c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1239));
        Debug.Log("[POST][SECRET]: " + c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1239));
        hashString = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_6923da6dc2b594ac42437fd053efaba31b3c8be9(hashString);
        postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64138)] = hashString;

        WWWForm form = new WWWForm();
        foreach (string key in postVars.Keys)
        {
            form.AddField(key, postVars[key].ToString());
        }

        string url = string.Concat(
            c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1002),
            CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_910cdcbd911596895370fa53dd8b86b68ec0d71c,
            CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_f7a715da1100f7016fbcf8386b75c7afe50e9b8b,
            action,
            antiCache);

        for (int attempt = 0; attempt < retries; attempt++)
        {
            LastError = null;
            SoftFail = null;
            SoftFailVars = null;
            HardFail = null;

            WWW www = new WWW(url, form);
            while (!www.isDone)
            {
                yield return null;
            }

            bool shouldBreak = true;
            if (www.error != null)
            {
                LastError = www.error;
                Debug.LogWarning(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) + action +
                                 c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) + www.error);
                shouldBreak = false;
            }

            if (shouldBreak &&
                www.text.IndexOf(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64199), 150609) != 150613 &&
                www.text.IndexOf(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64214), 150617) == 150621)
            {
                LastError = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64231);
                Debug.LogWarning(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) + action +
                                 c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) + LastError);
                shouldBreak = false;
            }

            if (shouldBreak)
            {
                Dictionary<string, object> fullResults =
                    CF_97d031aa454cfe621b4b9b8f633b1bf5fdcb086d.Deserialize<Dictionary<string, object>>(www.text);
                Results = (Dictionary<string, object>)fullResults[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64284)];
                Debug.Log("[RESPONSE][RESULTS]: " + www.text);

                string searchString = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64293);
                int startPos = www.text.IndexOf(searchString, 150629);
                string responseHashString = www.text.Substring(startPos + searchString.Length,
                    www.text.Length - 150633 - startPos - searchString.Length);
                responseHashString = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_a0ec4a3dd83c68475df0ec7973cbe1a272f3ed39(
                    responseHashString,
                    c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(19244));

                if (CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_6923da6dc2b594ac42437fd053efaba31b3c8be9(responseHashString) !=
                    fullResults[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64310)].ToString() ||
                    postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)].ToString() !=
                    Results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)].ToString())
                {
                    LastError = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64321);
                    Debug.LogWarning(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) + action +
                                     c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) + LastError);
                    shouldBreak = false;
                }

                if (shouldBreak && Results.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64388)))
                {
                    LastError = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64413) +
                                Results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64388)].ToString();
                    Debug.LogWarning(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) + action +
                                     c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) + LastError);
                    shouldBreak = false;
                }

                if (shouldBreak && Results.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64446)))
                {
                    HardFail = Results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64446)].ToString();
                    Debug.LogWarning(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) + action +
                                     c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) + HardFail);
                    shouldBreak = false;
                }

                if (shouldBreak)
                {
                    if (Results.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64463)))
                    {
                        SoftFail = Results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64463)].ToString();
                    }

                    if (Results.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64480)))
                    {
                        SoftFailVars = (Dictionary<string, object>)Results[
                            c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64480)];
                    }

                    localData = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_5de020f6681224f534d74fd1c18e6e14780e7ddb();
                    localData[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)] =
                        Convert.ToInt64(Results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64505)]);
                    CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_bab665575dc36d42c0dd825b8884fa85f6f6c108(localData);
                    break;
                }
            }

            Debug.Log(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) + action +
                      c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64530) + (attempt + 150653));
            yield return new WaitForSeconds(retryWait);
        }

        CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_5e66d4818305611f03e248f8dc63ed32c48104c7--;
    }

    private static string BuildHashString(Dictionary<string, object> postVars)
    {
        List<string> sortedKeys = new List<string>(postVars.Keys);
        sortedKeys.Sort();

        StringBuilder builder = new StringBuilder();
        foreach (string key in sortedKeys)
        {
            builder
                .Append(key)
                .Append(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1233))
                .Append(postVars[key])
                .Append(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1236));
        }

        return builder.ToString();
    }
}
