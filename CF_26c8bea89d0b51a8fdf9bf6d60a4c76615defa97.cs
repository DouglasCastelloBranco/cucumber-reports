using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using A;
using JsonFx.Json;
using UnityEngine;

public class CF_26c8bea89d0b51a8fdf9bf6d60a4c76615defa97
{
    public Dictionary<string, object> results;
    public string lastError;
    public string softFail;
    public Dictionary<string, object> softFailVars;
    public string hardFail;

    [DebuggerHidden]
    public IEnumerator Go(string action, Dictionary<string, object> postVars = null, int retries = 5, int retryWait = 2)
    {
        UnityEngine.Debug.Log("[POST][BODY]: endpoint=" + action + ", postVars=" + CF_761e4a3ab9b969f3e114c40a3160728194081507.Serialize(postVars));
        yield return CEMisc.StartCoroutineStatic(GoInternal(action, postVars, retries, retryWait));
    }

    [DebuggerHidden]
    private IEnumerator GoInternal(string action, Dictionary<string, object> postVars = null, int retries = 5, int retryWait = 2)
    {
        if (CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_910cdcbd911596895370fa53dd8b86b68ec0d71c == null ||
            CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_f7a715da1100f7016fbcf8386b75c7afe50e9b8b == null)
        {
            UnityEngine.Debug.LogError(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64030));
            yield break;
        }

        CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_5e66d4818305611f03e248f8dc63ed32c48104c7 += 1;

        string antiCache = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64117) +
                           CEMisc.Rand(0, 100000).ToString();
        if (action.IndexOf(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1256)) > -1)
        {
            antiCache = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1236) + antiCache;
        }
        else
        {
            antiCache = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1256) + antiCache;
        }

        if (postVars == null)
        {
            postVars = new Dictionary<string, object>();
        }

        Dictionary<string, object> sessionVars = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_5de020f6681224f534d74fd1c18e6e14780e7ddb();
        postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)] =
            CEMisc.CF_e57c757547290c33f0657c5a5f6b9c6c92edfc80();
        if (sessionVars.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)))
        {
            postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)] =
                Convert.ToDouble(sessionVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)]);
        }

        postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1181)] =
            (string)sessionVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1210)];

        string hashString = BuildHashString(postVars);
        hashString = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_a0ec4a3dd83c68475df0ec7973cbe1a272f3ed39(
            hashString,
            c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1239));
        UnityEngine.Debug.Log("[POST][SECRET]: " + c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1239));

        hashString = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_6923da6dc2b594ac42437fd053efaba31b3c8be9(hashString);
        postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64138)] = hashString;

        WWWForm form = BuildForm(postVars);

        string url = string.Concat(
            c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1002),
            CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_910cdcbd911596895370fa53dd8b86b68ec0d71c,
            CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_f7a715da1100f7016fbcf8386b75c7afe50e9b8b,
            action,
            antiCache);

        for (int i = 0; i < retries; i += 1)
        {
            lastError = null;
            softFail = null;
            softFailVars = null;
            hardFail = null;

            WWW www = new WWW(url, form);
            while (!www.isDone)
            {
                yield return null;
            }

            bool willBreak = true;
            if (www.error != null)
            {
                lastError = www.error;
                UnityEngine.Debug.LogWarning(
                    c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) +
                    action +
                    c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) +
                    www.error);
                willBreak = false;
            }

            if (willBreak && www.text.IndexOf(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64199), 0) != -1)
            {
                if (www.text.IndexOf(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64214), 0) == -1)
                {
                    lastError = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64231);
                    UnityEngine.Debug.LogWarning(
                        c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) +
                        action +
                        c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) +
                        lastError);
                    willBreak = false;
                }
            }

            if (willBreak)
            {
                Dictionary<string, object> fullResults =
                    CF_97d031aa454cfe621b4b9b8f633b1bf5fdcb086d.Deserialize<Dictionary<string, object>>(www.text);
                results = (Dictionary<string, object>)fullResults[
                    c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64284)];
                UnityEngine.Debug.Log("[RESPONSE][RESULTS]: " + www.text);

                string searchString = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64293);
                int startPos = www.text.IndexOf(searchString, 0);
                string responseHashString = www.text.Substring(
                    startPos + searchString.Length,
                    www.text.Length - 2 - startPos - searchString.Length);
                responseHashString = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_a0ec4a3dd83c68475df0ec7973cbe1a272f3ed39(
                    responseHashString,
                    c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(19244));

                if (CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_6923da6dc2b594ac42437fd053efaba31b3c8be9(responseHashString) !=
                    fullResults[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64310)].ToString() ||
                    postVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)].ToString() !=
                    results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)].ToString())
                {
                    lastError = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64321);
                    UnityEngine.Debug.LogWarning(
                        c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) +
                        action +
                        c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) +
                        lastError);
                    willBreak = false;
                }
            }

            if (willBreak && results.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64388)))
            {
                lastError = c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64413) +
                            results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64388)];
                UnityEngine.Debug.LogWarning(
                    c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) +
                    action +
                    c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) +
                    lastError);
                willBreak = false;
            }

            if (willBreak && results.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64446)))
            {
                hardFail = results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64446)].ToString();
                UnityEngine.Debug.LogWarning(
                    c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) +
                    action +
                    c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64180) +
                    hardFail);
                willBreak = false;
            }

            if (willBreak)
            {
                if (results.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64463)))
                {
                    softFail = results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64463)].ToString();
                }

                if (results.ContainsKey(c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64480)))
                {
                    softFailVars = (Dictionary<string, object>)results[
                        c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64480)];
                }
            }

            if (willBreak)
            {
                sessionVars = CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_5de020f6681224f534d74fd1c18e6e14780e7ddb();
                sessionVars[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1158)] =
                    Convert.ToInt64(results[c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64505)]);
                CF_cc5c171019b3fbb8c50a0900ac1a7900fb9f1267.CF_bab665575dc36d42c0dd825b8884fa85f6f6c108(sessionVars);
                break;
            }

            yield return new WaitForSeconds(retryWait);
            UnityEngine.Debug.Log(
                c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64147) +
                action +
                c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(64530) +
                (i + 1));
        }

        CF_44b706e36d672b6b10f038838eb6fc93dc8650c6.CF_5e66d4818305611f03e248f8dc63ed32c48104c7 -= 1;
    }

    private static string BuildHashString(Dictionary<string, object> postVars)
    {
        List<string> sortedKeys = new List<string>(postVars.Keys);
        sortedKeys.Sort();

        string hashString = string.Empty;
        foreach (string key in sortedKeys)
        {
            hashString = string.Concat(
                hashString,
                key,
                c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1233),
                postVars[key],
                c30df3218081f95188442b795df6adb13.c6f4ad10c9304b59afdcc32592176a672(1236));
        }

        return hashString;
    }

    private static WWWForm BuildForm(Dictionary<string, object> postVars)
    {
        WWWForm form = new WWWForm();
        foreach (string key in postVars.Keys)
        {
            form.AddField(key, postVars[key].ToString());
        }

        return form;
    }
}
