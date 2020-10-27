using Newtonsoft.Json;
using Notes.API.Models;
using Notes.MOBILE.Dtos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Notes.MOBILE.Data
{
    public class RestService : IRestService
    {
        private readonly HttpClient _client;
        public List<Note> Notes { get; set; }

        public RestService()
        {
            _client = GetClient();
        }
        public async Task AddNewNoteAsync(NoteCreateDto note)
        {
            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                string json = JsonConvert.SerializeObject(note);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PostAsync(uri, content);
                if(response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tNote succesfully added.");
                }

            }
            catch(Exception ex)
            {
                Debug.WriteLine(@"\tERROR: {0}", ex.Message);
            }
        }

        public async Task DeleteNoteAsync(int id)
        {
            Uri uri = new Uri(string.Format(Constants.RestUrl + "{0}", id));

            try
            {
                HttpResponseMessage response = await _client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tNote succesfully deleted.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR: {0}", ex.Message);
            }
        }

        public async Task EditNoteAsync(int id, NoteUpdateDto newNote)
        {
            Uri uri = new Uri(string.Format(Constants.RestUrl + "{0}", id));

            try
            {
                string json = JsonConvert.SerializeObject(newNote);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _client.PutAsync(uri, content);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tNote edited succesfully.");
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(@"\tERROR: {0}", ex);
            }

        }

        public async Task<List<Note>> GetAllNotesAsync()
        {
            Notes = new List<Note>();

            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);

                if(response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Notes = JsonConvert.DeserializeObject<List<Note>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Notes;
        }

        private HttpClient GetClient()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

    }
}
