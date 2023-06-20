/*
  'req' variable has:
    'Headers' - object with request headers
    'Payload' - request body data as a string
    'variables' - object with function variables

  'res' variable has:
    'Send(text, status)' - function to return text response. Status code defaults to 200
    'Json(obj, status)' - function to return JSON response. Status code defaults to 200
  
  If an error is thrown, a response with code 500 will be returned.
*/

using System.Threading.Tasks;

public async Task<RuntimeResponse> Main(RuntimeRequest req, RuntimeResponse res)
{
    var calc = new TestClassLibrary.Calculation();

    return res.Json(new()
    {
        { "areDevelopersAwesome", true },
        { "dllTest", calc.Add(1,2) }
    });
}
