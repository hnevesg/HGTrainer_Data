
    IEnumerator UploadCSV(string filePath)
    {
        string url = baseURL + UnityWebRequest.EscapeURL(Constants_Handball.identificador.ToString());

        Debug.Log("Starting CSV upload from: " + filePath);

        byte[] fileData = File.ReadAllBytes(filePath);
        string fileName = Path.GetFileName(filePath);

        WWWForm form = new WWWForm();
        form.AddBinaryData("file", fileData, fileName, "text/csv");

        UnityWebRequest request = UnityWebRequest.Post(url, form);
        request.downloadHandler = new DownloadHandlerBuffer();

        float startTime = Time.realtimeSinceStartup;
        yield return request.SendWebRequest();

        float endTime = Time.realtimeSinceStartup;
        float duration = endTime - startTime;

        Debug.Log($"⏱️ Tiempo total: {duration:F3} s");
        double fileSize = fileData.Length;
        double totalSize = fileSize + CalculateFormBoundaryOverhead(form);
        double overhead = totalSize - fileSize;
        Debug.Log("[EFFICIENCY] File total size (not including overhead): " + fileSize + " bytes");
        Debug.Log("[EFFICIENCY] Payload total size (including overhead): " + totalSize + " bytes");
        Debug.Log("[EFFICIENCY] Overhead size (headers, form boundaries, etc.): " + overhead + " bytes");
        Debug.Log("Overhead Ratio" + overhead / fileSize);
        Debug.Log("Efficiency" + fileSize/totalSize);

        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("Upload failed: " + request.error);
            Debug.LogError("response: " + request.downloadHandler.text);
            sendingNote.SetActive(false);
            wrongNote.SetActive(true);
            okNote.SetActive(false);
            yield return new WaitForSeconds(2);
            wrongNote.SetActive(false);
        }
        else if (request.responseCode == 200)
        {
            Debug.Log("Upload successful: " + request.downloadHandler.text);
            sendingNote.SetActive(false);
            okNote.SetActive(true);
            wrongNote.SetActive(false);
            yield return new WaitForSeconds(2);
            okNote.SetActive(false);
        }
        else
        {
            Debug.LogError("Upload failed with response code: " + request.responseCode);
            sendingNote.SetActive(false);
            wrongNote.SetActive(true);
            okNote.SetActive(false);
            yield return new WaitForSeconds(2);
            wrongNote.SetActive(false);
        }
    }

    double CalculateFormBoundaryOverhead(WWWForm form)
    {
        double overhead = 0;

        foreach (var header in form.headers)
        {
            overhead += header.Key.Length + header.Value.Length;
        }

        return overhead;
    }
