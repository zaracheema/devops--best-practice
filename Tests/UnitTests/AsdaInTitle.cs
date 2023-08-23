internal class Program
{
    private static void Main(string[] args)
    {
        @page "/"
        @using System.Net.Http @inject HttpClient Http

        @if (ViewData.ContainsKey("Title")) {
                    Assert.Contains("Asda", ViewData["Title"].ToString());
                } else
                {
                    Assert.Fail("ViewData does not contain a Title property.")
                        ;
                }
            }
        }