using System.IO;
using System.Net;
using System.Text;
using Microsoft.Extensions.Logging;
using NexusTravel.Common.StaticDataCache;
using NexusTravel.Dal.Models;

namespace NexusTravel.AirEngine.BritishAirway.Infrastructures
{
    public class SoapService : ISoapService
    {
        private readonly ILogger<SoapService> _logger;
        private readonly SystemSettingDto _systemSetting;

        public SoapService(ILogger<SoapService> logger,
            IStaticDataCachingService staticDataCachingService)
        {
            _logger = logger;
            _systemSetting = staticDataCachingService.SystemSettings();
        }

        public string SendRequest(string xml)
        {
            _logger.LogInformation($"Sending Request.");
            HttpWebRequest request = CreateWebRequest();

            byte[] xmlBytes = Encoding.UTF8.GetBytes(xml);

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(xmlBytes, 0, xmlBytes.Length);
            }

            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        string soapResult = sr.ReadToEnd();
                        return soapResult;
                    }
                }
                _logger.LogError(
                    $"Response Error:{response.StatusCode.ToString()} Exception: {response.StatusDescription}");
            }
            return "";
        }

        private HttpWebRequest CreateWebRequest()
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(_systemSetting.AirShoppingApiUrl);
            webRequest.Headers.Add(@"SOAP:Action");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Headers.Add("Client-key", _systemSetting.AirShoppingClientKey);
            webRequest.Headers.Add("SOAPAction", "AirShoppingV01");
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }
    }
}
