using System;
using System.Net;

namespace CustomProtocolDemo.WebServices
{
    public class RockWebRequestCreator : IWebRequestCreate
    {
        public WebRequest Create(Uri uri)
        {
            return new RockWebRequest(uri);
        }
    }
}