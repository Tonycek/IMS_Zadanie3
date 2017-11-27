using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IMS_Zadanie3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //InvokeRequestResponseService("4","12").Wait();
        }

        public async void NastavTextbox(string slovo)
        {
           // await Task.Run(() => ComputeNextMove(slovo));
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                double znamka = Double.Parse(slovo);
                string znamk;
                if (znamka < 0.65)
                    znamk = "A";

                else if (znamka >= 0.65 && znamka < 1.3)
                    znamk = "B";

                else if (znamka >= 1.3 && znamka < 2.05)
                    znamk = "C";

                else if (znamka >= 2.05 && znamka < 3.4)
                    znamk = "D";

                else if (znamka >= 3.4 && znamka < 4.2)
                    znamk = "E";

                else
                    znamk = "F";
                textbox.Text = znamk;
            });
        }

        private async Task ComputeNextMove(string slovo)
        {
            textbox.Text = slovo;
        }

        async Task InvokeRequestResponseService(string a, string b)
        {
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "Meno", ""
                                            },
                                            {
                                                "Obtiaznost predmetu", a
                                            },
                                            {
                                                "Pocet hodin ucenia", b
                                            },
                                            {
                                                "Znamka", "A"
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                var scoreRequest1 = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "Meno", ""
                                            },
                                            {
                                                "Obtiaznost predmetu", a
                                            },
                                            {
                                                "Pocet hodin ucenia", b
                                            },
                                            {
                                                "Znamka", "B"
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                var scoreRequest2 = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "Meno", ""
                                            },
                                            {
                                                "Obtiaznost predmetu", a
                                            },
                                            {
                                                "Pocet hodin ucenia", b
                                            },
                                            {
                                                "Znamka", "C"
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                var scoreRequest3 = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "Meno", ""
                                            },
                                            {
                                                "Obtiaznost predmetu", a
                                            },
                                            {
                                                "Pocet hodin ucenia", b
                                            },
                                            {
                                                "Znamka", "D"
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                var scoreRequest4 = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "Meno", ""
                                            },
                                            {
                                                "Obtiaznost predmetu", a
                                            },
                                            {
                                                "Pocet hodin ucenia", b
                                            },
                                            {
                                                "Znamka", "E"
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                var scoreRequest5 = new
                {
                    Inputs = new Dictionary<string, List<Dictionary<string, string>>>() {
                        {
                            "input1",
                            new List<Dictionary<string, string>>(){new Dictionary<string, string>(){
                                            {
                                                "Meno", ""
                                            },
                                            {
                                                "Obtiaznost predmetu", a
                                            },
                                            {
                                                "Pocet hodin ucenia", b
                                            },
                                            {
                                                "Znamka", "F"
                                            },
                                }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };

                const string apiKey = "59XVHV5iBhGi/0NJS9bg2bzJOUWdC+GIVa9ZLLKCklP3Pauh0Dh+1+cFq2RFy50yAnpe8bJpMwK+b+q9Csip2Q=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/6eff1d1ce26c4137b4b978125f663c17/services/bb62d32d86f54cf1a3662c6358355703/execute?api-version=2.0&format=swagger");

                // WARNING: The 'await' statement below can result in a deadlock
                // if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false)
                // so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)

                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest).ConfigureAwait(false);
                //HttpResponseMessage response1 = await client.PostAsJsonAsync("", scoreRequest1).ConfigureAwait(false);
                //HttpResponseMessage response2 = await client.PostAsJsonAsync("", scoreRequest2).ConfigureAwait(false);
                //HttpResponseMessage response3 = await client.PostAsJsonAsync("", scoreRequest3).ConfigureAwait(false);
                //HttpResponseMessage response4 = await client.PostAsJsonAsync("", scoreRequest4).ConfigureAwait(false);
                //HttpResponseMessage response5 = await client.PostAsJsonAsync("", scoreRequest5).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Result: {0}", result);
                    string substri = result.Substring(result.IndexOf("Scored Labels") + 16, 4);
                    NastavTextbox(substri);

                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp,
                    // which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }

                //if (response1.IsSuccessStatusCode)
                //{
                //    string result = await response1.Content.ReadAsStringAsync();
                //    Console.WriteLine("Result: {0}", result);
                //    string substri = result.Substring(result.IndexOf("Scored Labels") + 16, 4);
                //    NastavTextbox(substri);

                //}
                //else
                //{
                //    Console.WriteLine(string.Format("The request failed with status code: {0}", response1.StatusCode));

                //    // Print the headers - they include the requert ID and the timestamp,
                //    // which are useful for debugging the failure
                //    Console.WriteLine(response1.Headers.ToString());

                //    string responseContent = await response1.Content.ReadAsStringAsync();
                //    Console.WriteLine(responseContent);
                //}

                //if (response2.IsSuccessStatusCode)
                //{
                //    string result = await response2.Content.ReadAsStringAsync();
                //    Console.WriteLine("Result: {0}", result);
                //    string substri = result.Substring(result.IndexOf("Scored Labels") + 16, 4);
                //    NastavTextbox(substri);

                //}
                //else
                //{
                //    Console.WriteLine(string.Format("The request failed with status code: {0}", response2.StatusCode));

                //    // Print the headers - they include the requert ID and the timestamp,
                //    // which are useful for debugging the failure
                //    Console.WriteLine(response2.Headers.ToString());

                //    string responseContent = await response2.Content.ReadAsStringAsync();
                //    Console.WriteLine(responseContent);
                //}

                //if (response3.IsSuccessStatusCode)
                //{
                //    string result = await response3.Content.ReadAsStringAsync();
                //    Console.WriteLine("Result: {0}", result);
                //    string substri = result.Substring(result.IndexOf("Scored Labels") + 16, 4);
                //    NastavTextbox(substri);

                //}
                //else
                //{
                //    Console.WriteLine(string.Format("The request failed with status code: {0}", response3.StatusCode));

                //    // Print the headers - they include the requert ID and the timestamp,
                //    // which are useful for debugging the failure
                //    Console.WriteLine(response3.Headers.ToString());

                //    string responseContent = await response3.Content.ReadAsStringAsync();
                //    Console.WriteLine(responseContent);
                //}

                //if (response4.IsSuccessStatusCode)
                //{
                //    string result = await response4.Content.ReadAsStringAsync();
                //    Console.WriteLine("Result: {0}", result);
                //    string substri = result.Substring(result.IndexOf("Scored Labels") + 16, 4);
                //    NastavTextbox(substri);

                //}
                //else
                //{
                //    Console.WriteLine(string.Format("The request failed with status code: {0}", response4.StatusCode));

                //    // Print the headers - they include the requert ID and the timestamp,
                //    // which are useful for debugging the failure
                //    Console.WriteLine(response4.Headers.ToString());

                //    string responseContent = await response4.Content.ReadAsStringAsync();
                //    Console.WriteLine(responseContent);
                //}

                //if (response5.IsSuccessStatusCode)
                //{
                //    string result = await response5.Content.ReadAsStringAsync();
                //    Console.WriteLine("Result: {0}", result);
                //    string substri = result.Substring(result.IndexOf("Scored Labels") + 16, 4);
                //    NastavTextbox(substri);

                //}
                //else
                //{
                //    Console.WriteLine(string.Format("The request failed with status code: {0}", response5.StatusCode));

                //    // Print the headers - they include the requert ID and the timestamp,
                //    // which are useful for debugging the failure
                //    Console.WriteLine(response5.Headers.ToString());

                //    string responseContent = await response5.Content.ReadAsStringAsync();
                //    Console.WriteLine(responseContent);
                //}

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InvokeRequestResponseService(textboxInput1.Text, textboxInput2.Text).Wait();
        }
    }
}
